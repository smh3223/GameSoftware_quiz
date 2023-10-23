using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_cube_color : MonoBehaviour
{
    public Material material;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            material.color = Color.green;
        }
    }
}
