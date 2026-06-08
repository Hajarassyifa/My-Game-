using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;

    public float minX;
    public float maxX;

    void LateUpdate()
    {
        float targetX = Player.position.x;

        // batas kamera
        targetX = Mathf.Clamp(targetX, minX, maxX);

        transform.position = new Vector3(
            targetX,
            transform.position.y,
            transform.position.z
        );
    }
}