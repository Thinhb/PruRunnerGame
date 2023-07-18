using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    HitPlayer hitPlayer;
    Health health;
    private void Start()
    {
        health=FindObjectOfType<Health>();
        hitPlayer =FindObjectOfType<HitPlayer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hitPlayer.animator.SetBool("HitCheck", true);
            health.lostHealth();

        }
    }
}
