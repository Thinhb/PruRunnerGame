using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMagnet : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transformPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transformPlayer.position;
    }
   
}
