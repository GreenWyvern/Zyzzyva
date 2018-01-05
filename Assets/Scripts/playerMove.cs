using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public Transform SpawnPoint;
	bool respawn = false;
	private int state;
	int speed = 5;
	private float bulletSpeed = 20;
	public GameObject Bullet;
	int lives = 3;
	private List<GameObject> Projectile = new List<GameObject> ();
	//public Vector2 move = new Vector2 ();
	int bulletMoveA;
	int bulletMoveB;
    

    Rigidbody2D rBody;

    // Use this for initialization
    void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
        state = 0;
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			
			if (lives >= 0) {
				Destroy (other.gameObject);
				lives--;
				Respawn ();
			} 
		}
	}

	public void Respawn()
	{
		this.transform.position = SpawnPoint.position;
	}


	// Update is called once per frame
	void Update () {

		if (lives <= 0) {
			Destroy (gameObject);
		}

        #region Move

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //transform.position = new Vector2(this.transform.position.x , this.transform.position.y);
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        

        rBody.velocity = movement * speed;
        #endregion

        
        #region rotation

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (state == 1)
            {
                //if facing downwards
                this.transform.Rotate(0f, 0f, -180);
            }
            if (state == 2)
            {
                //if facing to the left
                this.transform.Rotate(0f, 0f, -90);
            }
            if (state == 3)
            {
                //if facing to the right
                this.transform.Rotate(0f, 0f, 90);
            }
            state = 0;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (state == 0)
            {
                //if facing upwards
                this.transform.Rotate(0f, 0f, 180);
            }
            if (state == 2)
            {
                //if facing to the left
                this.transform.Rotate(0f, 0f, 90);
            }
            if (state == 3)
            {
                //if facing to the right
                this.transform.Rotate(0f, 0f, -90);
            }
            state = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (state == 0)
            {
                //if facing upwards
                this.transform.Rotate(0f, 0f, 90);
            }
            if (state == 1)
            {
                //if facing downwards
                this.transform.Rotate(0f, 0f, -90);
            }
            if (state == 3)
            {
                //if facing to the right
                this.transform.Rotate(0f, 0f, 180);
            }
            state = 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (state == 0)
            {
                //if facing upwards
                this.transform.Rotate(0f, 0f, -90);
            }
            if (state == 1)
            {
                //if facing downwards
                this.transform.Rotate(0f, 0f, 90);
            }
            if (state == 2)
            {
                //if facing to the left
                this.transform.Rotate(0f, 0f, 180);
            }
            state = 3;
        }
        #endregion


		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			
			GameObject bullet = GameObject.Instantiate (this.Bullet, transform.position, Quaternion.identity);
			Projectile.Add (bullet);
			if (state == 0) {
				bulletMoveA = 0;
				bulletMoveB = 1;
			}
			if (state == 1) {
				bulletMoveA = 0;
				bulletMoveB = -1;
			}
			if (state == 2) {
				bulletMoveA = -1;
				bulletMoveB = 0;
			}
			if (state == 3) {
				bulletMoveA = 1;
				bulletMoveB = 0;
			}
		}

			for (int i = 0; i < Projectile.Count; i++) {            
				GameObject aBullet = Projectile [i];            
				if (aBullet != null) {                
					aBullet.transform.Translate (new Vector3 (bulletMoveA, bulletMoveB) * Time.deltaTime * bulletSpeed);
				}  
			}


    }
    

    

}
