using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItems : MonoBehaviour
{
    public GameObject[] ListItems;
    int randomItems;
    // Start is called before the first frame update
    void Start()
    {
        randomItems= Random.Range(0,ListItems.Length);
        Instantiate(ListItems[randomItems],transform.position,Quaternion.identity);
    }
}
