using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public Material bgMaterial;

    public float scrollSpeed = 0.2f;

    void Start()
    {
        bgMaterial.mainTextureOffset = Vector2.zero;
    }
    
    void Update()
    {
        Vector2 direction = Vector2.up;

        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
    
}
