using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

	public float speed = 1.0f;
	public float JumpSpeed = 2.0f; 
	public float fallSpeed = 2.5f; 

	public float ascentTime = 0.0f; 

	public Rigidbody2D rb; 

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>(); 
	
	}


	
	// Update is called once per frame
	void Update () {

		//basic movement for the character

		//this method allows for movement both on the horizontal and vertical axis
		//var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		//this method only allows horizontal movement
		var move = new Vector3(Input.GetAxis("Horizontal"),0, 0);
		transform.position += move * speed * Time.deltaTime;

	
		if(Input.GetButtonUp("Jump") == true){

			//rb.velocity = new Vector3 (0, 10, 0); 

			var moveVertTemp = new Vector3(0, JumpSpeed, 0); 
			transform.position += moveVertTemp * Time.deltaTime;

		} 



		//this method allows for jumping and holding down the jump key to ascend
		var moveVert = new Vector3(0, Input.GetAxis("Jump"), 0); 
			transform.position += moveVert * JumpSpeed * Time.deltaTime; 




		//used for quickly dropping down

		if(Input.GetAxis("Vertical") < 0){

			var moving = new Vector3(0, fallSpeed, 0); 
			transform.position -= moving * Time.deltaTime; 


		}

		//much less effective way of dropping the character
		//var moveDown = new Vector3(0, Input.GetAxis("Vertical"), 0); 
		//transform.position -= moveDown * fallSpeed * Time.deltaTime;  


	
	}//end of update

}//end of class
