using UnityEngine;


public class Waypoints : MonoBehaviour
{
    //웨이포인트에 자식들의 정보를 사용하기 위한 변수
    public static Transform[] points;

    private void Awake()
    {
        //자식의 수만큼 공간을 할당
        points = new Transform[transform.childCount];     
        for(int i=0;i<points.Length;i++)
        {
            points[i]=transform.GetChild(i);
        }
    }
}
