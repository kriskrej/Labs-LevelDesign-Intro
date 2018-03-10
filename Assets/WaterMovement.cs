using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour {
    float y0, r1, r2;
    public float maxY = 1f;

    void Start() {
        y0 = transform.position.y;
        r1 = Random.Range(0f, 1f);
        r2 = Random.Range(0f, maxY);
    }
	
	void Update () {
	    var y = y0 + Mathf.Sin(Time.timeSinceLevelLoad * r1) * r2;
	    transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}
}
