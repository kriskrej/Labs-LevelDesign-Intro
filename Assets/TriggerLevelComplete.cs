using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLevelComplete : MonoBehaviour {
    public GameObject endGameUiAndLogic;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
            endGameUiAndLogic.SetActive(true);
    }
}
