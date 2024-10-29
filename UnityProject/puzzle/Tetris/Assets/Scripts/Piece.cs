using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board { get; private set; }
    public TetrominoData data { get; private set; }
    public Vector3Int[] cells { get; private set; }
    public Vector3Int position { get; private set; }
    public void Initialize(Board board,Vector3Int position,TetrominoData data)
    {
        this.board = board;
        this.position = position;
        this.data = data;

        if(this.cells==null)
        {
            this.cells = new Vector3Int[data.cells.Length];
        }
    }
}
