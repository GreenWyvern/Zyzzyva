using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	
	public int verticalSpeed;

	// Use this for initialization
	void Start () {
		this.gameObject.name = "Bullet";	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Solid")
		{
			Destroy (gameObject);
		}
	}

	private void _checkBounds(){
		if (transform.position.y > 100f || transform.position.y < -100f || transform.position.x > 100f || transform.position.x < -100f) {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		this._checkBounds ();
	}


}
