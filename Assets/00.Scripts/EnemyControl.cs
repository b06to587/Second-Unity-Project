using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Vector2 limitPoint1;
    public Vector2 limitPoint2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



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
