using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day-Night Cycle Settings")]
    [Tooltip("Time (in seconds) for a full day to pass.")]
    public float dayDurationInSeconds = 60f; // Default is 60 seconds for a full day.

    // Internal variable to store rotation speed
    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed (degrees per second)
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the Directional Light around the X-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
