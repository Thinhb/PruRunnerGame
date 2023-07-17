using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMagnet : MonoBehaviour
{
    GameObject playerTranform;
    bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        playerTranform = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            Vector3 direction = playerTranform.transform.position - transform.position;
            direction.Normalize();
            transform.position += direction * 15f * Time.deltaTime;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerMagnet"))
        {
            
            check=true;
        }
    }
}
