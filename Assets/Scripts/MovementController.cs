using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;


    private void Update()
    {
        var dir = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir.z = -1;
        }

        dir.Normalize();

        GetComponent<Rigidbody>().velocity = speed * dir;
    }
}