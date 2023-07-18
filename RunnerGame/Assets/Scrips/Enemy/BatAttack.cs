using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAttack : MonoBehaviour
{
    GameObject playerTranform;
    BatAttackStop batAttackStop;
    public float moveForce = 10f;
    private Rigidbody2D rb;
    public Animator animator;
    bool checkattack;
    private void Start()
    {
        checkattack= true;
        batAttackStop = GetComponentInChildren<BatAttackStop>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        playerTranform = GameObject.FindGameObjectWithTag("Player");
        if (collision.gameObject.CompareTag("Player"))
        {
            if (checkattack)
            {
                rb = GetComponent<Rigidbody2D>();
                StartCoroutine(startAttack());
                checkattack= false;
            }           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SpikesWall"))
        {
            Destroy(gameObject);
        }
    }
    IEnumerator startAttack()
    {
        animator.SetBool("CheckAwake",true);
        yield return new WaitForSeconds(0.6f);
        animator.SetBool("CheckAwake", false);
        animator.SetBool("Checkattack", true);
        playerTranform = GameObject.FindGameObjectWithTag("Player");
        Vector2 direction = playerTranform.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * moveForce;
        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
     
    }
    private void FixedUpdate()
    {
        if (batAttackStop.checkAttack)
        {
            rb.velocity = new Vector2(0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
