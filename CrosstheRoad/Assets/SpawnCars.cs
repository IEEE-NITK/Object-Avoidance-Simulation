using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour {

	public GameObject car;
	// Use this for initialization
	void Start() {
		InstantiateCar();
	}
	
	void InstantiateCar()
	{
		GameObject new_car = (GameObject)Instantiate(car);
		System.Random r = new System.Random();
		int rInt = r.Next(10,35); //for ints
		new_car.transform.position = new Vector3(
					transform.position.x+(float)rInt,
					transform.position.y,
					transform.position.z);
					
		StartCoroutine("waitForSometime");
	}
	// Update is called once per frame
	IEnumerator waitForSometime()
	{
		yield return new WaitForSeconds(3.5f);
		InstantiateCar();
	}
	void Update (){
		
	}
}
