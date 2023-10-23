using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    int dir = 1;

    void Update()
    {
        transform.Translate(Vector3.left * speed * dir * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            dir = -1;
        }
        if(transform.position.x > 15f)
        {
            dir = 1;
        }
    }
}
