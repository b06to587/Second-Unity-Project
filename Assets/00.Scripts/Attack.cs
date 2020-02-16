using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public LayerMask LayerEnemy;
    public GameObject Bullet;
    Bullet bullet;

    public float tileDamage = 5f;
    private float rangeRadius = 2f;

    public float TimeLeft = 1.0f;
    private float nextTime = 0.0f;

    Vector2 vector_test;

    void Update()
    {
        //2초마다 실행
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            Generate();

        }
    }


    private void Generate()
    {
        //Bullet.bulletDamage = tileDamage;

        Instantiate(Bullet, this.transform.position, this.transform.rotation);
    }

}
