using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    public float rotate_speed = 100f;

    public Material material;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 0f, 1f) * speed * Time.deltaTime);
            material.mainTextureOffset += Vector2.up * speed * 0.1f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, 0f, -1f) * speed * Time.deltaTime);
            material.mainTextureOffset -= Vector2.up * speed * 0.1f * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -1f, 0f) * rotate_speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, 1f, 0f) * rotate_speed * Time.deltaTime);
        }
    }
}
