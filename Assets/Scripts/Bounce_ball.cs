using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_ball : MonoBehaviour
{

    public float jump_power = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹");
        GetComponent<Rigidbody>().AddForce(Vector3.up * jump_power);
    }
}
