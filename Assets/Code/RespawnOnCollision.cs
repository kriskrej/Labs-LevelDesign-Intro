using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnCollision : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
            SpawnPoint.ResetPlayerPosition();
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
            SpawnPoint.ResetPlayerPosition();
    }
}
