using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailWeakness : MonoBehaviour
{
    public GameObject SnailShell;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(SnailShell,transform.position+new Vector3(1f,0f,0f),Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
