using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObject gato; 
    public GameObject reflejo;

    public GameObject gatoParticlesPrefab;
    public GameObject reflejoParticlesPrefab;

    public float delayBeforeDestruction = 0f; // Delay time before destroying the player (in seconds)
    private float timeSinceTriggered = 0f; // Time elapsed since the destruction was triggered
    public bool destructionStarted = false; // Flag to check if the destruction process has started

    private SpriteRenderer gatoSpriteRenderer;
    private SpriteRenderer reflejoSpriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component from the player GameObject
        gatoSpriteRenderer = gato.GetComponent<SpriteRenderer>();
        reflejoSpriteRenderer = reflejo.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (destructionStarted)
        {
            timeSinceTriggered += Time.deltaTime; // Increase the time elapsed

            // Check if the time elapsed is greater than or equal to the specified delay
            if (timeSinceTriggered >= delayBeforeDestruction)
            {

                gatoSpriteRenderer.enabled = true;
                reflejoSpriteRenderer.enabled = true;
                levelManager.triggerGameOver();


                // Reset the flag to avoid repeated actions
                destructionStarted = false;
                
            }
        }
    }

    // Function to start the destruction process
    public void KillPlayerWithDelay()
    {
        // Start the delay countdown by setting the flag to true
        destructionStarted = true;
        timeSinceTriggered = 0f; // Reset the timer
        Instantiate(gatoParticlesPrefab, gato.transform.position, Quaternion.identity);
        Instantiate(reflejoParticlesPrefab, reflejo.transform.position, Quaternion.identity);
        gatoSpriteRenderer.enabled = false;
        reflejoSpriteRenderer.enabled = false;
    }
}
