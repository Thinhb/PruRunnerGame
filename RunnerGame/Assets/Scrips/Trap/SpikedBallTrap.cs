using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBallTrap : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Vector3 rotateAxis;
    [SerializeField] private float speed;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(rotateAxis * speed * Time.deltaTime);
    }
}
