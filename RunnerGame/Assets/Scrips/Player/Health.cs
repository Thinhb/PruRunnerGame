using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    int health;
    int currentHealth;
    public GameObject[] playerLifes;
    void Start()
    {
        health=3;
        currentHealth = health;
    }

    // Update is called once per frame
    public void lostHealth()
    {
        lostHealTime();
    }
    public void OnPlayerLifes(int currentLifes)
    {
        for (int i = 0; i < playerLifes.Length; i++)
        {
            if (i < currentLifes)
            {
                playerLifes[i].gameObject.SetActive(true);
            }
            else
            {
                playerLifes[i].gameObject.SetActive(false);
            }
        }
    }
    void lostHealTime()
    {
        currentHealth -= 1;
        OnPlayerLifes(currentHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void AddHealth()
    {
        if (currentHealth<3)
        {
            currentHealth += 1;
            OnPlayerLifes(currentHealth);
        }
        
    }
}
