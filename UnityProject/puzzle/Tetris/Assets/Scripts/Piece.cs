using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//보드랑 다르게 움직이는 피스를 관리하기위한 스크립트
public class Piece : MonoBehaviour
{    
    public NextPiece nextPiece;
    public Board board { get; private set; }
    
    public TetrominoData data { get; private set; }
    public Vector3Int[] cells { get; private set; }
    public Vector3Int position { get; private set; }
    public int rotationIndex { get; private set; }

    public float stepDelay = 1f;
    public float lockDelay = 0.5f;

    private float stepTime;
    private float lockTime;
    //피스생성
    public void Initialize(Board board,Vector3Int position,TetrominoData data)
    {
        this.board = board;
        this.position = position;
        this.data = data;
        this.rotationIndex = 0;
        this.stepTime = Time.time + this.stepDelay;
        this.lockTime = 0f;

        if(this.cells==null)
        {
            this.cells = new Vector3Int[data.cells.Length];
        }

        for (int i = 0; i < data.cells.Length; i++)
        {
            this.cells[i] = (Vector3Int)data.cells[i];
        }
    }

    //보드 오브젝트의 업데이트 작업이 이뤄짐
    private void Update()
    {
        //이거 함수로 바꿔 써봄
        //5분만 해볼까..?
        //일단 클리어하고
        this.board.Clear(this);

        this.lockTime += Time.deltaTime;
        //인풋으로 움직이고
        PlayerInput(board.playertype);
        //->> 여기가 넥스트 피스에서 사용한 정보를 가져다가 피스에게 옮겨줌
        //->> 그러면 해야하는 건 넥스트 피스에서 피스 셀 데이터 타일 데이터 가지고 와서
        //->> 그 데이터만 옮겨주기
        //->>어떤 상황에 하냐면 바닥에 붙은 상황에 다음 피스를 생성하는 상황에
        //->> 다음 피스를 랜덤으로 생성하지 말고 
        //->> 가지고 있던 피스 정보를 전달
        if (Time.time>=this.stepTime)
        {
            Step();
        }
        //움직였으니 그거 정보로 피스를 옮김
        this.board.Set(this);
    }

    private void PlayerInput(PlayerType playerType)
    {
        switch (playerType)
        {
            case PlayerType.Player1:
                if (Input.GetKeyDown(KeySetting.keys[KeyAction.LEFTROTATE]))
                {
                    Rotate(-1);
                }
                else if (Input.GetKeyDown(KeySetting.keys[KeyAction.RIGHTROTATE]))
                {
                    Rotate(1);
                }
                if (Input.GetKeyDown(KeySetting.keys[KeyAction.LEFT]))
                {
                    Move(Vector2Int.left);
                }
                else if (Input.GetKeyDown(KeySetting.keys[KeyAction.RIGHT]))
                {
                    Move(Vector2Int.right);
                }

                if (Input.GetKeyDown(KeySetting.keys[KeyAction.DOWN]))
                {
                    Move(Vector2Int.down);
                }

                if (Input.GetKeyDown(KeySetting.keys[KeyAction.HardDrop]))
                {
                    HardDrop();
                }
                break;
            case PlayerType.Player2:
                if (Input.GetKeyDown(KeyCode.LeftBracket))
                {
                    Rotate(-1);
                }
                else if (Input.GetKeyDown(KeyCode.RightBracket))
                {
                    Rotate(1);
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Move(Vector2Int.left);
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Move(Vector2Int.right); 
                }

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    Move(Vector2Int.down);
                }

                if (Input.GetKeyDown(KeyCode.RightShift))
                {
                    HardDrop();
                }
                break;
        }
    }
    private void Step()
    {
        this.stepTime = Time.time + this.stepDelay;

        Move(Vector2Int.down);

        if(this.lockTime>=this.lockDelay)
        {
            
            Lock();
        }
    }

    //타일 생성
    private void Lock()
    {
        this.board.Set(this);
        this.board.ClearLines();
        nextPiece.isCreate = true;
        this.board.SpawnPiece();
    }
    
    private void HardDrop()
    {
        while(Move(Vector2Int.down))
        {
            continue;
        }

        Lock();
    }
    private bool Move(Vector2Int translation)
    {
        Debug.Log(translation);
        Vector3Int newPosition = this.position;
        newPosition.x += translation.x;
        newPosition.y += translation.y;

        bool valid = this.board.IsValidposition(this,newPosition);
        
        if(valid)
        {
            this.position = newPosition;
            this.lockTime = 0f;
        }

        return valid;
    }

    private void Rotate(int direction)
    {
        int originalRotation = this.rotationIndex;
        this.rotationIndex += Wrap(this.rotationIndex + direction, 0, 4);

        ApplyRotationMatrix(direction);

        if (!TestWallKicks(this.rotationIndex,direction))
        {
            this.rotationIndex = originalRotation;
            ApplyRotationMatrix(-direction);
        }
    }

    private void ApplyRotationMatrix(int direction)
    {
        for (int i = 0; i < this.cells.Length; i++)
        {
            Vector3 cell = this.cells[i];

            int x, y;

            switch (this.data.tetromino)
            {
                case Tetromino.I:
                case Tetromino.O:
                    cell.x -= 0.5f;
                    cell.y -= 0.5f;
                    x = Mathf.CeilToInt((cell.x * Data.RotationMatrix[0] * direction) + (cell.y * Data.RotationMatrix[1] * direction));
                    y = Mathf.CeilToInt((cell.x * Data.RotationMatrix[2] * direction) + (cell.y * Data.RotationMatrix[3] * direction));
                    break;
                default:
                    x = Mathf.RoundToInt((cell.x * Data.RotationMatrix[0] * direction) + (cell.y * Data.RotationMatrix[1] * direction));
                    y = Mathf.RoundToInt((cell.x * Data.RotationMatrix[2] * direction) + (cell.y * Data.RotationMatrix[3] * direction));
                    break;
            }

            this.cells[i] = new Vector3Int(x, y, 0);
        }
    }

    private bool TestWallKicks(int rotationIndex,int rotationDirection)
    {
        int wallKickIndex = GetWallKickIndex(rotationIndex, rotationDirection);

        for(int i=0;i<this.data.wallKicks.GetLength(1);i++)
        {
            Vector2Int translataion = this.data.wallKicks[wallKickIndex, i];

            if(Move(translataion))
            {
                return true;
            }
        }

        return false;
    }

    private int GetWallKickIndex(int rotationIndex,int rotationDirection)
    {
        int wallKickIndex = rotationIndex * 2;

        if(rotationDirection<0)
        {
            wallKickIndex--;
        }

        return Wrap(wallKickIndex, 0, this.data.wallKicks.GetLength(0));
    }

    private int Wrap(int input,int min,int max)
    {
        if(input<min)
        {
            return max - (min - input) % (max - min);
        }
        else
        {
            return min + (input - min) & (max - min);
        }
    }
}
