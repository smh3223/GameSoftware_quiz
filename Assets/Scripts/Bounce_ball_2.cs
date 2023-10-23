using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_ball_2 : MonoBehaviour
{

    Rigidbody rig;

    private bool jump_state = false;
    public float jump_power = 500f;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jump_state == false)
        {
            jump_state = true;
            rig.AddForce(Vector3.up * jump_power);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Plane"))
        {
            jump_state = false;
        }
        else if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("게임 종료");
        }

    }

}
