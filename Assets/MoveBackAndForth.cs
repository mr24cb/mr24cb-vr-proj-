using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("The speed at which the object moves.")]
    public float speed = 3.0f;

    [Tooltip("The total distance the object will travel from its starting point.")]
    public float distance = 5.0f;

    [Tooltip("The axis along which the object moves. Default is X (Right).")]
    public Vector3 direction = Vector3.right;

    private Vector3 startPosition;

    void Start()
    {
        // Capture the object's position when the game starts
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new offset based on time, speed, and distance
        // Mathf.PingPong oscillates the value between 0 and 'distance'
        float currentDistance = Mathf.PingPong(Time.time * speed, distance);

        // Apply the offset to the starting position
        // We normalize the direction so the speed remains consistent regardless of vector length
        transform.position = startPosition + (direction.normalized * currentDistance);
    }
}