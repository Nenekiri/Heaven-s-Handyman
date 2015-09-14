using UnityEngine;
using System.Collections;

public class bimbytheBomb : MonoBehaviour {

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void FixedUpdate(){

		//allows the rigidbody to be woken up every couple of frames. 
		if (rb.IsSleeping()) {
			rb.WakeUp();
		}

	}

	//a way to check for the collsion using rigidbody that is woken up every frame
	void OnCollisionStay2D(Collision2D coli){
		Debug.Log ("Hit Bomb2"); 
		if(coli.gameObject.tag == "Player"){
			Application.LoadLevel(0); 
		}
	}

	//this method works as long as I have another seperate collider that is set 
	//to the same position and set to isTrigger
	/*void OnTriggerEnter2D(Collider2D col){
		
		Debug.Log ("Hit Bomb"); 
		if (col.gameObject.tag == "Player"){
			//Destroy(this.gameObject); 
			Application.LoadLevel(0); 
		}




	}*/

}//end of current class
