using UnityEngine;
using System.Collections;

public class MoveWithKeys : MonoBehaviour {
	
	public float moveSpeed = 10.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Translate(new Vector3(h, v, 0));
	}
}
