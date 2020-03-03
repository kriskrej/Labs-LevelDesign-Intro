using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour {
    float startWaterLevel;
    float waterLevelChange = 1f;

    void Start() {
        startWaterLevel = transform.position.y;
    }
	
	void Update () {
	    var newHeight = startWaterLevel + Mathf.Sin(Time.timeSinceLevelLoad * waterLevelChange);
	    transform.position = new Vector3(transform.position.x, newHeight, transform.position.z);
	}
}
