using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
	
	}

	void OnTriggerEnter2D(Collider2D col){
		
		Debug.Log ("Hit Player"); 
		if (col.gameObject.tag == "Player"){
			//Destroy(this.gameObject); 
			Application.LoadLevel(0); 
		}
	}
}//end of projectile class
