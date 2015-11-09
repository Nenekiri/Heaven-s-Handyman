using UnityEngine;
using System.Collections;

public class DramaticCamera : MonoBehaviour {

    Camera dramacamera; 

	// Use this for initialization
	void Start () {

        if (Globals.dramCamBool == true)
        {
            dramacamera = GetComponent<Camera>();
            dramacamera.fieldOfView = 154;
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //check for the option of drama camera being turned on. 
        if (Globals.dramCamBool == true)
        {
            if (dramacamera.fieldOfView > 91)
            {
                dramacamera.fieldOfView -= 0.2f;
            }
        }
	
	}


}
