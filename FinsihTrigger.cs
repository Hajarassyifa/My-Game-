using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public int unlockLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int currentUnlocked = PlayerPrefs.GetInt("UnlockedLevel", 1);

            if (unlockLevel > currentUnlocked)
            {
                PlayerPrefs.SetInt("UnlockedLevel", unlockLevel);
                PlayerPrefs.Save();
            }

            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene + 1);
        }
    }
}