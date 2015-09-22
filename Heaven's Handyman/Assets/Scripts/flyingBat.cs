using UnityEngine;
using System.Collections;

public class flyingBat : MonoBehaviour {

    public Sprite facingLeft;
    public Sprite facingRight;
    int direction; 

    int timer = 0;

    // Use this for initialization
    void Start () {

       direction = Random.Range(0, 2); 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        if (direction == 0) {

            this.GetComponent<SpriteRenderer>().sprite = facingLeft;

            timer++;
            if (timer >= 120)
            {
                timer = 0;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
                Destroy(this.gameObject, 4);
            }

        }

        if (direction > 0) {

            this.GetComponent<SpriteRenderer>().sprite = facingRight;

            timer++;
            if (timer >= 120)
            {
                timer = 0;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
                Destroy(this.gameObject, 4);
            }

        }



        

    }//end of fixed update function

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("Hit Player");
        if (col.gameObject.tag == "Player")
        {
             
            Application.LoadLevel("Test");
        }
    }
}
