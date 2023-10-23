using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_mng : MonoBehaviour
{
    public Material[] materials = new Material[4];
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeColor(0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeColor(1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeColor(2);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeColor(3);
        }
    }

    void ChangeColor(int num)
    {
        if (materials[num].color == Color.white)
        {
            materials[num].color = Color.red;
        }
        else if(materials[num].color == Color.red)
        {
            materials[num].color = Color.blue;
        }
        else if (materials[num].color == Color.blue)
        {
            materials[num].color = Color.green;
        }
        else if (materials[num].color == Color.green)
        {
            materials[num].color = Color.white;
        }
    }

}
