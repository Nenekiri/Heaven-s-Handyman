using UnityEngine;
using System.Collections;

public class scaryMask : MonoBehaviour {

    public float distance; 
    public GameObject target;

    int timer = 0; 

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {

        timer++; 

        distance = Vector3.Distance(this.transform.position, target.transform.position);
        if (distance < 50)
        {
            var dir = target.transform.position - transform.position;
            dir = dir.normalized; 
            this.GetComponent<Rigidbody2D>().AddForce(dir * 480 * Time.deltaTime);

        }

        if (timer >= 180)
        {
            Destroy(this.gameObject, 4);
        }


    }//end of fixed update

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("Hit Player");
        if (col.gameObject.tag == "Player")
        {

            Application.LoadLevel("Test");
        }
    }

}
