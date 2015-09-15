using UnityEngine;
using System.Collections;

public class bimbytheBomb : MonoBehaviour {

	public Rigidbody2D rb;
	public AudioSource audios; 
	public AudioClip beep; 

	public float distance; 
	public GameObject target; 





	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		audios = GetComponent<AudioSource>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}



	void FixedUpdate(){

		//allows the rigidbody to be woken up every couple of frames. 
		if (rb.IsSleeping()) {
			rb.WakeUp();
		}

		distance = Vector3.Distance(this.transform.position,target.transform.position);

	}

	void OnCollisionEnter2D(Collision2D c){

		
		if(distance < 50){
			audios.PlayOneShot(beep, 1);}

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
