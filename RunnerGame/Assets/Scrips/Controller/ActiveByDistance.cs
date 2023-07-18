using UnityEngine;

public class ActiveByDistance : MonoBehaviour
{
    Transform PlayerTranform; 
    public bool checkActive = false;
    Controller controller;
    private void Start()
    {
        controller=FindObjectOfType<Controller>();
    }
    void Update()
    {
        PlayerTranform = GameObject.FindGameObjectWithTag("Player").transform;

        if (PlayerTranform != null)
        {
            float distance = Vector3.Distance(transform.position, PlayerTranform.position);

            if (distance >= 80 && checkActive)
            {
                Destroy(gameObject);
                controller.checkActive = false;
            }
        }
       
    }
    
}
