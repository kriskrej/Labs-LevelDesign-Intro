using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameAfterSeconds : MonoBehaviour {
    float seconds = 1f;

	void Start () {
	    Invoke("Stop", seconds);	
	}
	
	
	void Stop () {
        #if UNITY_EDITOR
	    UnityEditor.EditorApplication.isPlaying = false;
	     #endif
        Debug.Log("Level complete, stopping playmode\n");
    }
}
