using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRun : MonoBehaviour
{
    // Start is called before the first frame update
    PathFollowEnemy pathFollowEnemy;
    public Animator animator;
    void Start()
    {
        pathFollowEnemy=GetComponentInChildren<PathFollowEnemy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pathFollowEnemy.enabled = true;
            animator.SetBool("checkRun", true);
        }
    }
}
