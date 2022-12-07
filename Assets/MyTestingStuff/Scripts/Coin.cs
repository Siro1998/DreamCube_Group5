using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Coin : MonoBehaviour {

    [SerializeField] float turnSpeed = 90f;
    public AudioSource audioSource;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.GetComponent<Damage>() != null) {
            Destroy(gameObject);
            return;
        }

        // Check that the object we collided with is the player
        if (!other.gameObject.CompareTag("Ball")) {
            return;
        }

        // Add to the player's score
        GameManager.inst.IncrementScore(20);
        audioSource.Play();
        // Destroy this coin object
        Destroy(gameObject);
    }

    private void Start () {

	}

	private void Update () {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
	}
}