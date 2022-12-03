using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField] float turnSpeed = 90f;

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

        // lose to the player's score
        GameManager.inst.IncrementScore();


    }

    private void Start () {

	}

	private void Update () {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
	}
}
