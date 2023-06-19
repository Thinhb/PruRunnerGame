using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMapGave : MonoBehaviour
{
    public GameObject mapStartGave;
    public GameObject mapHaveGave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")) 
        {
            mapHaveGave.SetActive(false);
            Instantiate(mapStartGave,mapHaveGave.transform.position,Quaternion.identity);
        }
    }
}
