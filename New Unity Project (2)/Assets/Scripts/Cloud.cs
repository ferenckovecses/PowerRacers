using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {
	Rigidbody rb;
	public float moveRange = 1.5f;
	public float speed = 100f;
	bool novekszik = true;
	float fixPlace;

	void Start(){
		rb = this.GetComponent<Rigidbody>();
		fixPlace = this.transform.position.z;
		}




	// Update is called once per frame
	void Update () {
			
		if(fixPlace < fixPlace*2f && novekszik){
			rb.Sleep ();
			rb.AddForce (0, 0, speed * Time.deltaTime, ForceMode.VelocityChange);
			if (rb.position.z > fixPlace * moveRange) {
				novekszik = !novekszik;
			}
		}

		if(!novekszik){
				rb.Sleep ();
				rb.AddForce (0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
			if(rb.position.z < fixPlace *  -moveRange){
				novekszik = !novekszik;
			}
		}
	}
}
	