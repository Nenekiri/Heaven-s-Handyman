﻿using UnityEngine;
using System.Collections;

public class wallOfFire : MonoBehaviour {

    

	Vector3 wallSpeed = new Vector3(0, 0.08f, 0);
    Vector3 speedUp = new Vector3(0, 1.0f, 0);

    public float timer = 0;

    public tk2dSprite lavaSprite; 



    public float distance;
    public GameObject target;

    public AudioSource a; 

    // Use this for initialization
    void Start () {

        //rb = GetComponent<Rigidbody2D>();

        target = GameObject.Find("test_player_3");
        a = GetComponent<AudioSource>();

        

    }

	//public GameObject Player; 
	

	//only updates once every couple of frames. Using it to help with performance. 
	void FixedUpdate(){ 

       float wallPosition = this.transform.position.y;
        float playerPosition = target.transform.position.y; 

		transform.Translate(wallSpeed);

        distance = Vector3.Distance(this.transform.position, target.transform.position);

        if (distance > 60)
        {
            wallPosition = playerPosition - 20.0f;
            transform.Translate(speedUp);  

        }

       

        if (Globals.lavaSound == true)
        {

            if (distance < 30)
            {

                a.volume = 0.45f;

            }

            else if (distance > 30)
            {
                a.volume = 0.15f;
            }
        }

        else if (Globals.lavaSound == false) {
            a.volume = 0.00f; 
        }
        


    }


	// Update is called once per frame
	void Update () {
	
	}


		
		
		

}
