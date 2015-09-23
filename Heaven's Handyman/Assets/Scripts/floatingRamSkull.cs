using UnityEngine;
using System.Collections;

public class floatingRamSkull : MonoBehaviour {

	public GameObject projectile; 
	int timer = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Wait(){


		yield return new WaitForSeconds(5); 

	}



	void FixedUpdate(){

		timer ++;
		if(timer >= 120){
			timer = 0;
			GameObject clone = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
			clone.GetComponent<Rigidbody2D>().velocity = new Vector2(-5,0);
			Destroy(clone, 4);  
		}
		//StartCoroutine(Wait()); 

	}//end of fixed update

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("Hit Player");
        if (col.gameObject.tag == "Player")
        {

            Application.LoadLevel("Test");
        }
    }//end of OnTriggerEnter2D

}//end of class definition

