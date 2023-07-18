using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RinoAttack : MonoBehaviour
{
    public float forceMagnitude = 10f;

    private Rigidbody2D rb;
    PathFollowEnemy pathFollowEnemy;
    public Animator animator;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pathFollowEnemy=GetComponent<PathFollowEnemy>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SpikesWall"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            pathFollowEnemy.enabled = false;
            if (transform.localScale.x==1)
            {
                Vector2 force = -transform.right * forceMagnitude;
                rb.AddForce(force, ForceMode2D.Impulse);
                animator.SetBool("CheckAttack", true);


            }
            if (transform.localScale.x ==-1)
            {
                Vector2 force = transform.right * forceMagnitude;
                rb.AddForce(force, ForceMode2D.Impulse);
                animator.SetBool("CheckAttack", true);

            }
        }
    }
}
