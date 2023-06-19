using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaknessPointEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyDie;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemyDie.transform.localScale=enemy.transform.localScale;
            Instantiate(enemyDie,enemy.transform.position,enemyDie.transform.rotation);
            Destroy(enemy);
        }
    }
}
