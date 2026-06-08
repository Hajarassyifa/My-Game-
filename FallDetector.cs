using UnityEngine;

public class FallDetectorScript : MonoBehaviour
{
    // Tentukan seberapa besar damage (kurang nyawa) saat jatuh
    public int damageAmount = 1;

    // Fungsi bawaan Unity yang akan aktif saat ada objek masuk area Trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Cek apakah objek yang masuk memiliki Tag "Player"
        if (other.CompareTag("Player"))
        {
            // Ambil skrip PlayerHealth dari objek Player tersebut
            PlayerHealth playerHealthScript = other.GetComponent<PlayerHealth>();

            // Jika skrip ditemukan, kurangi nyawanya
            if (playerHealthScript != null)
            {
                playerHealthScript.TakeDamage(damageAmount);
            }
        }
    }
}