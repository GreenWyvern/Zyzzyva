using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladyMovement2 : MonoBehaviour {

		public float speed;
		public float rotation;
		private float currentRot;
		private bool initial = true;

		Rigidbody2D rBody;

		// Use this for initialization
		void Start () {
			rBody = this.GetComponent<Rigidbody2D>();
			this.transform.Rotate(0f, 0f, rotation);

		if(rotation == 90)
			{
				rBody.velocity = this.transform.right * speed;
			}
			else
			{
				rBody.velocity = this.transform.up * speed;
			}


		}

		void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Solid")
			{
				if (initial)
				{
					this.transform.Rotate(0f, 0f, rotation-180);
					if (rotation == -90.00001)
					{ rBody.velocity = this.transform.right * -speed; } 
				else { rBody.velocity = this.transform.up * -speed; }
					initial = false;
				}
			else if (initial == false)
				{
					this.transform.Rotate(0f, 0f, rotation);
					if (rotation == 90)
					{ rBody.velocity = this.transform.right * speed; } else { rBody.velocity = this.transform.up * speed; }
					initial = true;
				}
			}
		}
		void OnCollisionEnter2D(Collision2D other)
		{
			if(other.gameObject.tag == "Bullet")
			{
				Destroy (gameObject);
			}
		}

		// Update is called once per frame
		void Update () {
			#region Move

			//transform.position = new Vector2(this.transform.position.x , this.transform.position.y);

			#endregion

		}
	}
