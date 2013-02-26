using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	public Rigidbody bullet;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Fire1")) {
			Rigidbody projectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			projectile.name = "Shot";
			projectile.AddForce(transform.forward * 3500);
		}
	}
}
