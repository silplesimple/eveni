using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NextPiece : MonoBehaviour
{
    //가지고 있는 기능만 구현
    public Tile tile;
    public Board board;
    public Piece trackingPiece;

    public Tilemap tilemap { get; private set; }

    public Vector3Int[] cells; //{ get; private set; }
    public Vector3Int position { get; private set; }

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();
        this.cells = new Vector3Int[4];
    }

    private void LateUpdate()
    {
        Clear();
        //Copy();
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
    //카피할 필요없음 피스를 새로 만들어서 가져다 주는 역활이기 때문에
    //private void Copy()
    //{
    //    for (int i = 0; i < this.cells.Length; i++)
    //    {
    //        this.cells[i] = this.trackingPiece.cells[i];
    //    }
    //}
    //드롭도 필요없음
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
