using UnityEngine;
using UnityEngine.Tilemaps;


public class Board : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }
    public Piece activePiece { get; private set; }
    //public NextPiece NextPiece { get; private set; }
    public TetrominoData[] tetrominoes;
    public Vector3Int spawnPosition;
    public Vector2Int boardSize = new Vector2Int(10, 20);
    public PlayerType playertype;
    [SerializeField]
    private Vector3Int nextSpawnPosition;
    int score = 10;
    UIManager uiManager;
    //�ؽ�Ʈ �ǽ��� ������ ������ ��ȯ �װ����� �����ϰ� �ִٰ� ��Ƽ�� �ǽ����� ī���� ������ ü����
    

    public RectInt Bounds
    {
        get
        {
            Vector2Int position = new Vector2Int(-this.boardSize.x / 2, -this.boardSize.y / 2);
            return new RectInt(position, this.boardSize);
        }
       
    }

    private void Awake()
    {        
        uiManager = FindObjectOfType<UIManager>();
        this.tilemap = GetComponentInChildren<Tilemap>();
        this.activePiece = GetComponentInChildren<Piece>();
        for(int i=0;i<this.tetrominoes.Length;i++)
        {
            this.tetrominoes[i].Initalize();
        }
    }

    private void Start()
    {
        SpawnPiece();
    }

    
    public void SpawnPiece()
    {
        //Random.Range(0, this.tetrominoes.Length);
        int random = activePiece.nextPiece.randomCellLength;
        //������ ���� ��Ʈ���� �����͸� ������
        TetrominoData data = this.tetrominoes[random];
        Debug.Log(activePiece.nextPiece.randomCellLength);
        this.activePiece.Initialize(this, this.spawnPosition,data);

        if(IsValidposition(this.activePiece,this.spawnPosition))
        {
            Set(this.activePiece);                
        }
        else
        {
            GameOver();
        }        
    }

    private void GameOver()
    {
        this.tilemap.ClearAllTiles();
    }
    //�ǽ��� �����͸� ������ Ÿ���� ����
    public void Set(Piece piece)
    {
        for(int i = 0; i < piece.cells.Length;i++)
        {
            Vector3Int tilePosition = piece.cells[i]+piece.position;
            this.tilemap.SetTile(tilePosition, piece.data.tile);
        }
    }

    public void Clear(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            Vector3Int tilePosition = piece.cells[i] + piece.position;
            this.tilemap.SetTile(tilePosition, null);
        }
    }

    public bool IsValidposition(Piece piece,Vector3Int position)
    {
        RectInt bounds = this.Bounds;
        for(int i=0;i<piece.cells.Length;i++)
        {
            Vector3Int tilePosition = piece.cells[i] + position;           

            if(!bounds.Contains((Vector2Int)tilePosition))
            {
                return false;
            }
            if(this.tilemap.HasTile(tilePosition))
            {
                return false;
            }
        }

        return true;
    }

    public void ClearLines()
    {
        RectInt bounds = this.Bounds;
        int row=bounds.yMin;

        while(row<bounds.yMax)
        {
            if(IsLineFull(row))
            {
                LineClear(row);
            }
            else
            {
                row++;
            }
        }
    }

    public Tile GetTile(int index)
    {
        return tetrominoes[index].tile;
    }
    private bool IsLineFull(int row)
    {
        RectInt bounds = this.Bounds;
        
        for(int col=bounds.xMin;col<bounds.xMax;col++)
        {
            Vector3Int position = new Vector3Int(col, row, 0);

            if(!this.tilemap.HasTile(position))
            {
                return false;
            }
        }
        return true;
    }

    private void LineClear(int row)
    {
        RectInt bounds = this.Bounds;

        uiManager.PlusScore(score);
        for (int col=bounds.xMin;col<bounds.xMax;col++)
        {
            Vector3Int position = new Vector3Int(col, row, 0);
            this.tilemap.SetTile(position, null);
        }

        while(row<bounds.yMax)
        {
            for(int col= bounds.xMin;col<bounds.xMax;col++)
            {
                Vector3Int position = new Vector3Int(col, row + 1, 0);
                TileBase above = this.tilemap.GetTile(position);

                position = new Vector3Int(col, row, 0);
                this.tilemap.SetTile(position, above);
            }

            row++;
        }
    }

}
