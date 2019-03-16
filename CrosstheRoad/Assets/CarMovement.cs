using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {
	
	bool shouldMove=true;
	public float force = 1000;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {
		rb.freezeRotation = true;
		//if(shouldMove)
		{
		rb.AddForce(0,0,-force*Time.deltaTime,ForceMode.VelocityChange);}
	}
}
