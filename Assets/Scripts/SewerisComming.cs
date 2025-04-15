using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewerisComming : MonoBehaviour
{
    public float delay = 7.0f; // Delay in seconds before the object starts moving
    public float speed = 1.3f; // Speed at which the object moves upward
    private bool startMoving = false; // Flag to check if we should start moving
    public GameObject playerObj;
    public PlayerControl playerControl;

    void Start()
    {
        // Start the coroutine to handle the delay
        StartCoroutine(StartMovingAfterDelay());
    }

    private IEnumerator StartMovingAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);
        startMoving = true; // Set the flag to true to start moving
    }

    void Update()
    {
        // Check if we should move the object
        if (startMoving)
        {
            // Move the object upward along the y-axis
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D theSewer)
    {
        if (theSewer.CompareTag("Player"))
        {
            playerControl.diePlayer();
        }
    }
}
