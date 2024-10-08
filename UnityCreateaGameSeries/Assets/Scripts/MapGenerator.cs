using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
public class MapGenerator:MonoBehaviour
{
    public Map[] maps;
    public int mapIndex;

    public Transform tilePrefab;
    public Transform obstaclePrefab;
    public Transform mapFloor;
    public Transform navmeshFloor;
    public Transform navmeshMastPrefab;

    public Vector2 MaxMapSize;
    

    [Range(0,1)]
    public float outlinePercent;    

    public float tileSize;

    List<Coord> allTileCoords;
    Queue<Coord> shuffledTileCoords;
    Queue<Coord> shuffledOpenTileCoords;
    Transform[,] tileMap;

    Map currentMap;
 
    void Awake()
    {
        FindObjectOfType<Spawner>().OnNewWave += OnNewWave;
    }

    void OnNewWave(int waveNumber)
    {
        mapIndex = waveNumber - 1;
        GenerateMap();
    }
    public void GenerateMap()
    {
        currentMap = maps[mapIndex];
        tileMap = new Transform[currentMap.mapSize.x, currentMap.mapSize.y];
        System.Random prng = new System.Random(currentMap.seed);       

        // Generating coords;
        allTileCoords = new List<Coord>();
        for(int x=0;x<currentMap.mapSize.x;x++)
        {
            for(int y=0;y<currentMap.mapSize.y;y++)
            {
                allTileCoords.Add(new Coord(x, y));
            }
        }
        shuffledTileCoords = new Queue<Coord>(Utility.ShuffleArray(allTileCoords.ToArray(), currentMap.seed));
        
        // Create map holder object       
        string holderName = "Generated Map";
        if(transform.Find(holderName))
        {
            DestroyImmediate(transform.Find(holderName).gameObject);
        }

        Transform mapHolder = new GameObject(holderName).transform;
        mapHolder.parent = transform;

        
        //Spawning tiles
        for(int x=0;x<currentMap.mapSize.x;x++)
        {
            for(int y=0;y<currentMap.mapSize.y;y++)
            {
                Vector3 tilePosition = CoordToPosition(x,y);
                Transform newTile = Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.right * 90))as Transform;
                newTile.localScale = Vector3.one * (1 - outlinePercent)*tileSize;
                newTile.parent = mapHolder;
                tileMap[x, y] = newTile;
            }

        }

        //Spawning obstacles
        bool[,] obstacleMap = new bool[(int)currentMap.mapSize.x, (int)currentMap.mapSize.y];

        int obstacleCount =(int)(currentMap.mapSize.x * currentMap.mapSize.y * currentMap.obstaclePercent);
        int currentObstacleCount = 0;
        List<Coord> allOpenCoords = new List<Coord>(allTileCoords);
        for(int i=0;i<obstacleCount;i++)
        {
            Coord randomCoord = GetRandomCoord();
            obstacleMap[randomCoord.x, randomCoord.y] = true;
            currentObstacleCount++;
            if (randomCoord != currentMap.mapCenter && MapIsFullyAccessible(obstacleMap, currentObstacleCount))
            {
                float obstacleHeight = Mathf.Lerp(currentMap.minObstacleHeight, currentMap.maxObstacleHeight, (float)prng.NextDouble());
                Vector3 obstaclePosition = CoordToPosition(randomCoord.x, randomCoord.y);
                //stacleMap
                Transform newObstacle = Instantiate(obstaclePrefab, obstaclePosition+Vector3.up*obstacleHeight/2, Quaternion.identity) as Transform;
                newObstacle.parent = mapHolder;
                newObstacle.localScale = new Vector3((1 - outlinePercent) * tileSize,obstacleHeight,(1-outlinePercent)*tileSize);

                Renderer obstacleRenderer = newObstacle.GetComponent<Renderer>();
                Material obstacleMaterial = new Material(obstacleRenderer.sharedMaterial);
                float colorPercent = randomCoord.y / (float)currentMap.mapSize.y;
                obstacleMaterial.color = Color.Lerp(currentMap.foregroundColor, currentMap.backgroundColor, colorPercent);
                obstacleRenderer.sharedMaterial = obstacleMaterial;

                allOpenCoords.Remove(randomCoord);
            }
            else
            {
                obstacleMap[randomCoord.x, randomCoord.y] = false;
                currentObstacleCount--;
            }
        }//mapHolder Vector3

        shuffledOpenTileCoords = new Queue<Coord>(Utility.ShuffleArray(allOpenCoords.ToArray(), currentMap.seed));

        //Creating navmesh mask
        NavMaskDirection(Vector3.left, mapHolder);
        NavMaskDirection(Vector3.right, mapHolder);
        NavMaskDirection(Vector3.forward, mapHolder);
        NavMaskDirection(Vector3.back, mapHolder);
    }

    private void NavMaskDirection(Vector3 direction,Transform mapParent)
    {        
        if(Mathf.Abs(direction.x)==1)
        {
            Transform navMask = Instantiate(navmeshMastPrefab, direction * (currentMap.mapSize.x + MaxMapSize.x) / 4f * tileSize, Quaternion.identity) as Transform;
            navMask.parent = mapParent;
            navMask.localScale = new Vector3((MaxMapSize.x - currentMap.mapSize.x) / 2f, 1, currentMap.mapSize.y) * tileSize;                       
        }
        else
        {
            Transform navMask = Instantiate(navmeshMastPrefab, direction * (currentMap.mapSize.y + MaxMapSize.y) / 4f * tileSize, Quaternion.identity) as Transform;
            navMask.parent = mapParent;
            navMask.localScale = new Vector3(currentMap.mapSize.x, 1,  (MaxMapSize.y - currentMap.mapSize.y) /2f) * tileSize;
            //navMask.localScale = new Vector3(currentMap.mapSize.y*2, 1,  (maxcurrentMap.mapSize.x - currentMap.mapSize.x) /2) * tileSize;                       
        }
        navmeshFloor.localScale = new Vector3(MaxMapSize.x, MaxMapSize.y) * tileSize;
        mapFloor.localScale = new Vector3(currentMap.mapSize.x * tileSize, currentMap.mapSize.y * tileSize);
    }

    bool MapIsFullyAccessible(bool[,] obstacleMap,int currentObstacleCount)
    {
        bool[,] mapFlags = new bool[obstacleMap.GetLength(0), obstacleMap.GetLength(1)];
        Queue<Coord> queue = new Queue<Coord>();
        queue.Enqueue(currentMap.mapCenter);
        mapFlags[currentMap.mapCenter.x, currentMap.mapCenter.y] = true;

        int accessibleTileCount = 1;

        while(queue.Count>0)
        {
            Coord tile = queue.Dequeue();

            for(int x=-1;x<=1;x++)
            {
                for(int y=-1;y<=1;y++)
                {
                    int neighbourX = tile.x + x;
                    int neighbourY = tile.y + y;
                    if(x==0||y==0)
                    {
                        if(neighbourX>=0&&neighbourX<obstacleMap.GetLength(0)&&neighbourY>=0&&neighbourY<obstacleMap.GetLength(1))
                        {
                            if (!mapFlags[neighbourX, neighbourY] && !obstacleMap[neighbourX,neighbourY])
                            {
                                mapFlags[neighbourX, neighbourY] = true;
                                queue.Enqueue(new Coord(neighbourX, neighbourY));
                                accessibleTileCount++;
                            }
                        }
                    }
                }

            }
        }
        int targetAccessibleTileCount = (int)(currentMap.mapSize.x * currentMap.mapSize.y - currentObstacleCount);
        return targetAccessibleTileCount == accessibleTileCount;
    }    

    private Vector3 CoordToPosition(int x, int y)
    {
        //return new Vector3(-currentMap.mapSize.x / 2 + 0.5f + x, 0, -currentMap.mapSize.y / 2 + 0.5f + y)*tileSize;
        return new Vector3(-currentMap.mapSize.x / 2f + 0.5f + x,0, -currentMap.mapSize.y / 2f + 0.5f + y)*tileSize;
    }

    public Transform GetTileFromPosition(Vector3 position)
    {
        int x = Mathf.RoundToInt( position.x / tileSize + (currentMap.mapSize.x - 1) / 2f);
        int y = Mathf.RoundToInt(position.z / tileSize + (currentMap.mapSize.y - 1) / 2f);
        x = Mathf.Clamp(x, 0, tileMap.GetLength(0)-1);
        y = Mathf.Clamp(y, 0, tileMap.GetLength(1)-1);
        return tileMap[x, y];
    }

    public Coord GetRandomCoord()
    {
        Coord randomCoord = shuffledTileCoords.Dequeue();
        shuffledTileCoords.Enqueue(randomCoord);
        return randomCoord;
    }

    public Transform GetRandomOpneTile()
    {
        Coord randomCoord = shuffledOpenTileCoords.Dequeue();
        shuffledTileCoords.Enqueue(randomCoord);
        return tileMap[randomCoord.x, randomCoord.y];
    }

    [System.Serializable]
    public struct Coord
    {
        public int x;
        public int y;

        public Coord(int _x,int _y)
        {
            x = _x;
            y = _y;
        }

        public static bool operator==(Coord c1,Coord c2)
        {
            return c1.x == c2.x && c1.y == c2.y;
        }
        public static bool operator !=(Coord c1, Coord c2)
        {
            return !(c1 == c2);
        }

    }

    [System.Serializable]
    public class Map
    {
        public Coord mapSize;
        [Range(0,1)]
        public float obstaclePercent;
        public int seed;
        public float minObstacleHeight;
        public float maxObstacleHeight;
        public Color foregroundColor;
        public Color backgroundColor;

        public Coord mapCenter
        {
            get { return new Coord(mapSize.x / 2, mapSize.y / 2); }
        }
    }

}
