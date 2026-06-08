using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Pengaturan Pergerakan")]
    public float speed = 5f; // Kecepatan jalan normal
    public float jf = 400f;  // Kekuatan lompat (Jump Force)

    private Rigidbody2D rb;
    private float arahHorizontal;
    private bool mauLompat = false;

    private void Start()
    {
        // Mengambil komponen Rigidbody2D dari karakter saat game dimulai
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // PENTING: Pakai GetAxisRaw supaya karakter LANGSUNG berhenti saat tombol dilepas
        arahHorizontal = Input.GetAxisRaw("Horizontal");

        // Membaca tombol Spasi (Jump) di Update agar tidak pernah macet
        if (Input.GetButtonDown("Jump"))
        {
            mauLompat = true;
        }
    }

    private void FixedUpdate()
    {
        // 1. Logika Berjalan
        rb.linearVelocity = new Vector2(arahHorizontal * speed, rb.linearVelocity.y);

        // 2. Logika Melompat
        if (mauLompat == true)
        {
            rb.AddForce(new Vector2(0, jf)); // Memberikan dorongan ke atas
            mauLompat = false;               // Reset memori lompat
        }
    }
}