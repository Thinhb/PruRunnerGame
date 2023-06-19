using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Animator animator;
    public Transform pointJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("CheckTrampoline"))
        {
            StartCoroutine(ActiveTrampoline());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("CheckTrampoline", true);
        }
    }
    public IEnumerator ActiveTrampoline()
    {
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("CheckTrampoline", false);
    }
}
