using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public string sceneName;
    public int levelIndex;

    void Start()
    {
        Button btn = GetComponent<Button>();

        if (PlayerPrefs.GetInt("LevelReached", 1) >= levelIndex)
        {
            btn.interactable = true;
        }
        else
        {
            btn.interactable = false;
        }
    }

    public void OpenLevel()
    {
        SceneManager.LoadScene(sceneName);
    }
}