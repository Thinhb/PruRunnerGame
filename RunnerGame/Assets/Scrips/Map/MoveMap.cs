using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    public float speed;
    
    private void Start()
    {
        speed = Controller.FindObjectOfType<Controller>().speedMap;
    }
    private void Update()
    {
        speed = Controller.FindObjectOfType<Controller>().speedMap;
        Vector3 movement = new Vector3(-1f, 0f, 0f);
        movement = movement.normalized;
        transform.position += movement * speed * Time.deltaTime;
    }
}
