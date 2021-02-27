using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;


    void OnTriggerEnter(Collider other) {
        // Check if the object that triggers a collision is the player
        if(other.gameObject.CompareTag("Player")) {
            // Player's CharacterController Reference.
            var controller = other.gameObject.GetComponent<CharacterController>();
            // Turn controller off
            controller.enabled = false;
            //Move the player to the SpawnPoint.
            other.gameObject.transform.position = spawnPoint.position;
            // Turn it back on.
            controller.enabled = true;

        }
    }
}
