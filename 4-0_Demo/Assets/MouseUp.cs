using UnityEngine;
using System.Collections;

public class MouseUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0)) {
			rigidbody.AddForce(Vector3.up * 500);	
		}
	}
}
