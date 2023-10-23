using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Factory : MonoBehaviour
{
    float create_time;
    float current_time;

    public GameObject Monster;

    void Start()
    {
        current_time = 0f;
        create_time = 5f;
    }
    
    void Update()
    {
        current_time += Time.deltaTime;
        if(current_time > create_time)
        {
            Vector3 CreatePos = new Vector3(Random.Range(-9.5f, 9.5f), 0.5f, 9f);
            Instantiate(Monster).transform.position = CreatePos;
            current_time = 0f;
        }
    }
}
