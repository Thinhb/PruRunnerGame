using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{
    public float pointSpawnMap;
    public float mapLength;
    public float speedMap;
    public float timeIncrementSpeed = 15f;
    public float time;
    public bool checkActive;

    private void Start()
    {
        checkActive = true;
        time = timeIncrementSpeed;
    }
    private void Update()
    {
        incrementSpeed();
    }
    public void incrementSpeed()
    {
        if ((time -= Time.deltaTime) <= 0)
        {
            speedMap += 0.5f;
            time = timeIncrementSpeed;
        }
    }
}
