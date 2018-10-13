using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("zesty");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
