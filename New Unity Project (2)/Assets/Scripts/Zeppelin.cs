using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeppelin : MonoBehaviour {
	Rigidbody rb;
	public float moveRange = 1.5f;
	public float speed = 100f;
	bool novekszik = false;
	float fixPlace;

	void Start(){
		rb = this.GetComponent<Rigidbody>();
		fixPlace = this.transform.position.x;

	}




	// Update is called once per frame
	void FixedUpdate () {

		if(fixPlace < fixPlace*2f && novekszik){
			rb.Sleep ();
			rb.AddForce (speed * Time.deltaTime, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
			if (rb.position.x > fixPlace * moveRange) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 45, 0),  1f);
				novekszik = !novekszik;
			}
		}

		if(!novekszik){
			rb.Sleep ();
			rb.AddForce (-speed * Time.deltaTime, 0, speed * Time.deltaTime, ForceMode.VelocityChange);
			if(rb.position.x < fixPlace *  -moveRange){
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 225, 0),  1f);
				novekszik = !novekszik;
			}
		}
	}
}
	