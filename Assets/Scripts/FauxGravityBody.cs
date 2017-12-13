using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor; 
	private Transform myTransform; 

	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();

		rb.constraints = RigidbodyConstraints.FreezeRotation;
		rb.useGravity = false; 
		myTransform = transform; 
	}
	
	void Update () {
		attractor.Attract (myTransform); 
	}
}
