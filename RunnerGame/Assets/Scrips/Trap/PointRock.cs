using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointRock : MonoBehaviour
{
    public GameObject[] Rock;
    GameObject rockInstantiate;
    public Transform parent;
    public Transform mapPosition;
    public bool checkSpawn;
    // Start is called before the first frame update
    private void Start()
    {
        checkSpawn = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (checkSpawn)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                int randomRock = Random.Range(0, Rock.Length);
                rockInstantiate = Instantiate(Rock[randomRock], transform.position - mapPosition.position, Quaternion.identity);
                rockInstantiate.transform.SetParent(parent, false);
                checkSpawn = false;
            }
        }
       
    }
}
