using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;

    int health;

    void Start()
    {
        health = hearts.Length;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health--;

            hearts[health].SetActive(false);
        }
    }

    public void Heal()
    {
        if (health < hearts.Length)
        {
            hearts[health].SetActive(true);

            health++;
        }
    }
}