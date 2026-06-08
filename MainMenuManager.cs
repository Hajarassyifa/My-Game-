using UnityEngine;
using UnityEngine.SceneManagement; // Penting untuk pindah scene

public class MainMenuManager : MonoBehaviour
{
    // Fungsi untuk tombol Play/Level
    public void BukaLevel(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }

    // Fungsi untuk memunculkan/menutup Panel (seperti Info atau Settings)
    public void TogglePanel(GameObject panel)
    {
        bool isActive = panel.activeSelf;
        panel.SetActive(!isActive);
    }

    // Fungsi untuk keluar game
    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("Game Keluar"); // Muncul di console saat testing
    }
}