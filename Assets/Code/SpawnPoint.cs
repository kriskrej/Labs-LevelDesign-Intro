using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject playerPrefab;
    GameObject player;
    static SpawnPoint instance;

    void Awake() {
        instance = this;
        player = Instantiate(playerPrefab);
        ResetPlayerPosition();
        player.name = "Player";
        gameObject.SetActive(false);
    }

    public static void ResetPlayerPosition() {
        if (instance == null) {
            Debug.LogError("No spawn point");
            return;
        }
        instance.player.transform.position = instance.transform.position;
        instance.player.transform.rotation = instance.transform.rotation;
        instance.player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
