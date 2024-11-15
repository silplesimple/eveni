using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NextPiece : MonoBehaviour
{
    //������ �ִ� ��ɸ� ����
    public Tile tile;
    public Board board;
    //public Piece trackingPiece;
    public TetrominoData[] boardTetromino;
    public bool isCreate=true;
    public int randomCellLength { get; private set; }

    public Tilemap tilemap { get; private set; }

    public Vector3Int[] cells { get; private set; }
    public Vector3Int position { get; private set; }

    public TileBase activeTile { get; private set; }

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();
        this.cells = new Vector3Int[4];
    }

    private void Start()
    {
        boardTetromino = board.tetrominoes;                
    }

    private void LateUpdate()
    {
        Clear();
        //Copy();
        if(isCreate)
        {
            CreateCell();
        }
        //Drop();
        Set();
    }
    private void Clear()
    {
        for (int i = 0; i < this.cells.Length; i++)
        {
            Vector3Int tilePosition = this.cells[i] + this.position;
            this.tilemap.SetTile(tilePosition, null);
        }
    }
    private void CreateCell()
    {
        randomCellLength = Random.Range(0, boardTetromino.Length);
        tile=board.GetTile(randomCellLength); 
        Debug.Log(randomCellLength);
        Vector3Int[] boardCells = new Vector3Int[cells.Length];
        
        for(int i=0;i<cells.Length;i++)
        {
            //������ ���� ����ȯ
            Vector2Int convertCells = this.boardTetromino[randomCellLength].cells[i];
            Debug.Log(convertCells);
            boardCells[i] = new Vector3Int(convertCells.x-1, convertCells.y-1);
            this.cells[i] = boardCells[i];
        }
        isCreate = false;

        //for(int i=0;i<this.cells.Length;i++)
        //{
        //    this.cells[i] = this.boardTetromino[randomCellLength].cells;
        //}
    }
    //ī���� �ʿ���� �ǽ��� ���� ���� ������ �ִ� ��Ȱ�̱� ������
    //private void Copy()
    //{
    //    for (int i = 0; i < this.cells.Length; i++)
    //    {
    //        this.cells[i] = this.trackingPiece.cells[i];
    //    }
    //}
    //��ӵ� �ʿ����
    //private void Drop()
    //{
    //    Vector3Int position = this.trackingPiece.position;

    //    int current = position.y;
    //    int bottom = -this.board.boardSize.y / 2 - 1;

    //    this.board.Clear(this.trackingPiece);

    //    for (int row = current; row >= bottom; row--)
    //    {
    //        position.y = row;

    //        if (this.board.IsValidposition(this.trackingPiece, position))
    //        {
    //            this.position = position;
    //        }
    //        else
    //        {
    //            break;
    //        }
    //    }

    //    this.board.Set(this.trackingPiece);
    //}

    private void Set()
    {
        for (int i = 0; i < this.cells.Length; i++)
        {
            Vector3Int tilePosition = this.cells[i] + this.position;
            this.tilemap.SetTile(tilePosition, this.tile);
        }
    }
}
