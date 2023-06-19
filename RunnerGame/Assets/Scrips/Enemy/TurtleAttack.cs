using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject weaknessEnemy;
    PathFollowEnemy pathFollow;
    float movespeed;
    void Start()
    {
        pathFollow=FindObjectOfType<PathFollowEnemy>();
        movespeed = pathFollow.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("checkAttack", true);
            
            pathFollow.moveSpeed= 0f;
            if (GameObject.Find("ColliderWeakness"))
            {
                weaknessEnemy.SetActive(false);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(statusChange());
        }
    }
    IEnumerator statusChange()
    {
        yield return new WaitForSeconds(1f);
        pathFollow.moveSpeed = movespeed;
        animator.SetBool("checkAttack", false);
        weaknessEnemy.SetActive(true);
    }
}
