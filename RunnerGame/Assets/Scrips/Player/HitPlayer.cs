using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;
    Trampoline trampoline;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trampoline=FindObjectOfType<Trampoline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("HitCheck"))
        {
            StartCoroutine(Hurt());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rb.velocity = new Vector2(0f, 7f).normalized * 15f;
            //transform.position = transform.position*speed* new Vector3(1f,3f,0f);
        }
        if(collision.gameObject.CompareTag("Trap")) 
        {
            animator.SetBool("HitCheck", true);
        }
        if (collision.gameObject.CompareTag("TrapTramploline"))
        {
            //rb.velocity = new Vector2(0f, 20f).normalized * 30f;
            //transform.position = transform.position*speed* new Vector3(1f,3f,0f);
            //rb.AddForce(trampoline.pointJump.up * 30f, ForceMode2D.Impulse);
            rb.AddForce(transform.up * 30f, ForceMode2D.Impulse);


        }
    }
    public IEnumerator Hurt()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("HitCheck", false);
    }
}
