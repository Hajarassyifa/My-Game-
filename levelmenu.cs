using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelmenu : MonoBehaviour
{
    public Button[] buttons;

    private void Awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

        // Disable semua tombol
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i] != null)
            {
                buttons[i].interactable = false;
            }
        }

        // Batasi supaya tidak error
        int maxLevel = Mathf.Min(unlockedLevel, buttons.Length);

        // Unlock level
        for (int i = 0; i < maxLevel; i++)
        {
            if (buttons[i] != null)
            {
                buttons[i].interactable = true;
            }
        }
    }

    public void OpenLevel(int levelId)
    {
        SceneManager.LoadScene("level " + levelId);
    }
}