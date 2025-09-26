using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float speed = 50f;      // Tilt speed
    public float limit = 20f;      // Max tilt angle (degrees)

    private float currentTiltX = 0f;   // Forward-backward tilt (around X axis)
    private float currentTiltZ = 0f;   // Left-right tilt (around Z axis)

    void Update()
    {
        // Get input
        float inputX = Input.GetAxis("Vertical");   // Forward/backward
        float inputZ = Input.GetAxis("Horizontal"); // Left/right

        // Apply input scaled by speed and time
        currentTiltX += inputX * speed * Time.deltaTime;
        currentTiltZ += inputZ * speed * Time.deltaTime;

        // Clamp angles
        currentTiltX = Mathf.Clamp(currentTiltX, -limit, limit);
        currentTiltZ = Mathf.Clamp(currentTiltZ, -limit, limit);

        // Apply rotation (Euler uses X for forward/backward, Z for left/right)
        transform.rotation = Quaternion.Euler(currentTiltX, 0f, -currentTiltZ);
    }
}

