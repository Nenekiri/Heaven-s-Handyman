using UnityEngine;
using System.Collections;

public class DramaticCamera : MonoBehaviour {

    Camera dramacamera; 

	// Use this for initialization
	void Start () {
        dramacamera = GetComponent<Camera>();
        dramacamera.fieldOfView = 154; 
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (dramacamera.fieldOfView > 91) {
            dramacamera.fieldOfView -= 0.2f; 
        }
	
	}


}
