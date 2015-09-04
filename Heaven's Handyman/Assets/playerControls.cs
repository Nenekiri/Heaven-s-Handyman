using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

	public float speed = 1.0f;
	public float JumpSpeed = 2.0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//basic movement for the character

		//this method allows for movement both on the horizontal and vertical axis
		//var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		//this method only allows horizontal movement
		var move = new Vector3(Input.GetAxis("Horizontal"),0, 0);
		transform.position += move * speed * Time.deltaTime;

		//this method allows for jumping... a lot
		var moveVert = new Vector3(0, Input.GetAxis("Jump"), 0); 
		transform.position += moveVert * JumpSpeed * Time.deltaTime; 


	
	}
}
