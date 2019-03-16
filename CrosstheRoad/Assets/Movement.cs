using UnityEngine;

public class Movement : MonoBehaviour {

	public float force = 1000;
	public Rigidbody rb;
	public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.freezeRotation = true;
		if ( Input.GetKey("d"))
		{
			rb.AddForce(force*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		else if(Input.GetKey("a"))
		{
			rb.AddForce(-force*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		else if(Input.GetKey("w")){
			rb.AddForce(0,0,force*Time.deltaTime,ForceMode.VelocityChange);
		}
		else if(Input.GetKey("s")){
			rb.AddForce(0,0,-force*Time.deltaTime,ForceMode.VelocityChange);
		}
		
		Vector3 vecplusx = new Vector3(20,player.position.y,player.position.z);
		Vector3 vecminusx = new Vector3(-20,player.position.y,player.position.z);
		Vector3 vecplusz = new Vector3(player.position.x,player.position.y,20);
		Vector3 vecminusz = new Vector3(player.position.x,player.position.y,-20);
		if(player.position.x > 20)
		{
			player.position  = vecplusx;
			rb.velocity = new Vector3(0,0,0);
		}
		else if(player.position.x <-20)
		{
			
			player.position  = vecminusx;
			rb.velocity = new Vector3(0,0,0);
		}
		
		else if(player.position.z > 20)
		{
			player.position  = vecplusz;
			rb.velocity = new Vector3(0,0,0);
		}
		else if(player.position.z <-20)
		{
			
			player.position  = vecminusz;
			rb.velocity = new Vector3(0,0,0);
		}
		
	}
}
