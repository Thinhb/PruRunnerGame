using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PowerMagnet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            activePower();
        }
    }
    IEnumerator activePower()
    {
        PowerMagnet.SetActive(true);
        yield return new WaitForSeconds(5f);
        PowerMagnet.SetActive(false);
    }
}
