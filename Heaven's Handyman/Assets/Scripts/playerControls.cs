using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

	public Transform wall; 

	public float speed = 1.0f;
	public float JumpSpeed = 2.0f; 
	public float fallSpeed = 2.5f; 

	public float ascentTime = 0.0f; 

	public Rigidbody2D rb;

    
	// Use this for initialization
	void Start () {



		rb = GetComponent<Rigidbody2D>(); 
	
	}


	void FixedUpdate(){

		//checks for the position of the player in the y-axis and will "kill" the player 
		//when he goes past the y-position of the wall of death. 
		if (this.transform.position.y <= wall.transform.position.y){

            //Application.LoadLevel("Test"); 

            Globals.death = true; 

		}

		//basic movement for the character
		
		//this method allows for movement both on the horizontal and vertical axis
		//var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		
		//this method only allows horizontal movement
		Vector2 move = new Vector2(Input.GetAxis("Horizontal"), 0);
		//transform.position += move * speed * Time.deltaTime;
		
		float grav = rb.velocity.y - 0.25f; 
		rb.velocity = move * speed * Time.deltaTime * 100;
		
		
		
		if(Input.GetButtonUp("Jump") == true){
			
			//rb.velocity = new Vector3 (0, 10, 0); 
			
			//var moveVertTemp = new Vector3(0, JumpSpeed, 0); 
			//transform.position += moveVertTemp * Time.deltaTime;
			
			grav = 9.5f; 
			
			
			
		} 
		
		rb.velocity = new Vector2(rb.velocity.x, grav); 
		
		
		
		//this method allows for jumping and holding down the jump key to ascend
		//var moveVert = new Vector3(0, Input.GetAxis("Jump"), 0); 
		//transform.position += moveVert * JumpSpeed * Time.deltaTime; 

		if(Input.GetButtonDown("Jump") == true){

			grav = 10.5f; 



		}
		
		rb.velocity = new Vector2(rb.velocity.x, grav); 
		
		
		//used for quickly dropping down
		
		if(Input.GetAxis("Vertical") < 0){
			
			var moving = new Vector3(0, fallSpeed, 0); 
			//transform.position -= moving * Time.deltaTime; 
			
			rb.velocity = -moving * Time.deltaTime * 100; 
			

			//Debug.Log(fallSpeed); 
		}
		
		//much less effective way of dropping the character
		//var moveDown = new Vector3(0, Input.GetAxis("Vertical"), 0); 
		//transform.position -= moveDown * fallSpeed * Time.deltaTime;  



	}
	// Update is called once per frame
	void Update () {




	
	}//end of update

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("Hit"); 
		if (other.tag == "Wall"){

            //Application.LoadLevel("Test");

            Globals.death = true;     
         
		}
	}

}//end of class