using UnityEngine;
using System.Collections;

public class wallOfFire : MonoBehaviour {

	Vector3 wallSpeed = new Vector3(0, 0.05f, 0); 

	// Use this for initialization
	void Start () {

		//rb = GetComponent<Rigidbody2D>(); 
	
	}

	//public GameObject Player; 
	

	//only updates once every couple of frames. Using it to help with performance. 
	void FixedUpdate(){

		transform.Translate(wallSpeed); 


	}


	// Update is called once per frame
	void Update () {
	
	}


		
		
		

}
