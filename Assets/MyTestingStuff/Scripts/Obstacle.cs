using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public AudioSource audioSource;
    
    private void OnTriggerEnter (Collider other)
    {
        // Check that the object we collided with is the player
        if (other.gameObject.CompareTag("Ball")) {
            // lose to the player's score
            GameManager.inst.DecrementScore();
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
