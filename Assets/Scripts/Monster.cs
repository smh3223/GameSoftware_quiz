using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private GameObject target;

    public float speed = 1f;
   
    void Start()
    {
        target = Camera.main.gameObject;
        transform.LookAt(target.transform);
    }
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
