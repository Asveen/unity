using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumps : MonoBehaviour {

	public GameObject cube;
	public Vector3 jf;
	// Use this for initialization
	void Start () {
		jf = new Vector3 (0f, 10f, 0f);
		
	}
    void OnTriggerEnter()
    {
        print("Collision Detected");
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			cube.GetComponent<Rigidbody>().AddForce (jf);
            
		}
	}
}
