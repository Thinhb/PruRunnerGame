using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSnail : MonoBehaviour
{
    Rigidbody2D rb;
    bool checkGround;
    ShellSnailCheck check;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        check=FindObjectOfType<ShellSnailCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        ForceShell();
    }
    void ForceShell()
    {
        if (check.GetComponent<ShellSnailCheck>().checkDirection)
        {
            rb.velocity = new Vector2(15f, 0f).normalized * 15f;
        }
        else
        {
            rb.velocity = new Vector2(-15f, 0f).normalized * 15f;
            transform.localScale = new Vector2(-1, 1);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SpikesWall"))
        {
            Destroy(gameObject);
        }
    }
}
