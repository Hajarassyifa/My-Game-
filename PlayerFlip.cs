using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float arah = Input.GetAxisRaw("Horizontal");

        if (arah > 0)
        {
            spriteRenderer.flipX = false; // hadap kanan
        }
        else if (arah < 0)
        {
            spriteRenderer.flipX = true; // hadap kiri
        }
    }
}