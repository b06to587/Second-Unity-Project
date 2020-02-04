using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    //이동체크포인트 제한
    public Vector2 limitPoint1;
    public Vector2 limitPoint2;

    public enum checkPoint
    {
        point1,point2,point3,point4
    }
    checkPoint nowPoint;




    //에너미 스테이터스 영역
    public float enemySpeed= 0.05f;
    public float enemyHp = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        nowPoint = checkPoint.point1;
        StartCoroutine(moveToPoint());
        
    }

    // Update is called once per frame
    void Update()
    {
    // transform.position=Vector2.MoveTowards(transform.position,limitPoint1,enemySpeed*Time.deltaTime);
    }



    IEnumerator moveToPoint()
    {
        //리미트포인트 1은 좌상단 2는 우하단
        Vector2 startPoint= new Vector2(limitPoint1.x, limitPoint2.y);
        Vector2 firstPoint= new Vector2(limitPoint1.x, limitPoint1.y);
        Vector2 secondPoint= new Vector2(limitPoint2.x, limitPoint1.y);
        Vector2 finalPoint= new Vector2(limitPoint2.x, limitPoint2.y);
       

        transform.position=startPoint;

        while(true)
        {
            
            Debug.Log("dd");
            transform.position=Vector2.MoveTowards(transform.position,limitPoint1,enemySpeed*Time.deltaTime);
              yield return null;
        }
           
       yield return null;
       
    }





    //에너미 이동경로 찍어줌
      private void OnDrawGizmos()
    {
        Vector2 limitPoint3 = new Vector2(limitPoint2.x,limitPoint1.y); 
        Vector2 limitPoint4 = new Vector2(limitPoint1.x,limitPoint2.y);
        Gizmos.color =Color.red;
        Gizmos.DrawLine(limitPoint1,limitPoint3);
        Gizmos.DrawLine(limitPoint3,limitPoint2);
        Gizmos.DrawLine(limitPoint1,limitPoint4);
        Gizmos.DrawLine(limitPoint4,limitPoint2);
    }

}
