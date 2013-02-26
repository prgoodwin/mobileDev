using UnityEngine;
using System.Collections;

public class ButtonRelease : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")) {
			rigidbody.AddForce(Vector3.up * 500);	
		}
	}
}
