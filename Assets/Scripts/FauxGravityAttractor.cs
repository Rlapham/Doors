using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour {

	public Rigidbody rigid; 
//	public Rigidbody rb = GetComponent<Rigidbody>();
	public float gravity = -10; 

//	void Start()
//	{
//		rigid = GetComponent<Rigidbody>();
//	}

	public void Attract(Transform body){
		Vector3 gravityUp = (body.position - transform.position).normalized; 
		Vector3 bodyUp = body.up; 

		rigid.AddForce (gravityUp * gravity); 

		Quaternion targetRotation = Quaternion.FromToRotation (bodyUp, gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp (body.rotation, targetRotation, 50 * Time.deltaTime); 
		
	}
}