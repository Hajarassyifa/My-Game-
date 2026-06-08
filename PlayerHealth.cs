using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;

    public GameObject[] hearts;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
            health = 0;

        UpdateHearts();

        if (health == 0)
        {
            SceneManager.LoadScene("mAINMenu");
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].SetActive(true);
            else
                hearts[i].SetActive(false);
        }
    }
}