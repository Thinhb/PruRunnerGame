using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActiveByDistanceItems : MonoBehaviour
{
    Transform PlayerTranform;
    ActiveByDistance activeByDistance;
    // Start is called before the first frame update
    void Start()
    {
        activeByDistance=FindObjectOfType<ActiveByDistance>();
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerTranform = GameObject.FindGameObjectWithTag("Player").transform;

        if (PlayerTranform!=null)
        {
            float distance = Vector2.Distance(transform.position, PlayerTranform.position);

            if (distance >= 80 && activeByDistance.checkActive)
            {
                Destroy(gameObject);

            }
        }
       
    }
}
