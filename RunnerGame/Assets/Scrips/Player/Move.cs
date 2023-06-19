using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    Controller controller;
    private void Start()
    {
        controller=FindObjectOfType<Controller>();
    }
    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput > 0)
        {
            speed = 3;
        }
        if(horizontalInput < 0)
        {
            speed= controller.speedMap+2;
        }
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;
        transform.position += movement;
    }
}
