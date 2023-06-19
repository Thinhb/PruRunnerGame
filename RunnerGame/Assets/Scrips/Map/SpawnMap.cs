using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    public GameObject[] MapList;
    Transform positionSpawnMap;
    float position;
    Controller controler;
    ActiveByDistance activeByDistance;
    bool checkSpawnOneTime;
    void Start()
    {
       controler = FindObjectOfType<Controller>();
       position = controler.GetComponent<Controller>().pointSpawnMap;
       activeByDistance=FindObjectOfType<ActiveByDistance>();
       checkSpawnOneTime = true;


    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player") && checkSpawnOneTime)
        {          
            positionSpawnMap = GameObject.FindGameObjectWithTag("Ground").transform;
            int intMap = UnityEngine.Random.Range(0, MapList.Length);
            Instantiate(MapList[intMap],
                new Vector2(positionSpawnMap.position.x + position,transform.position.y),
                Quaternion.identity);
            checkSpawnOneTime=false;
            activeByDistance.GetComponent<ActiveByDistance>().checkActive = true;
            if (controler.checkActive)
            {
                if (controler.GetComponent<Controller>().pointSpawnMap<110)
                {
                    controler.GetComponent<Controller>().pointSpawnMap += controler.GetComponent<Controller>().mapLength;

                }
            }
        }
    }
}
