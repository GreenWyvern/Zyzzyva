﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.name = "leaf";	
	}
		
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			Destroy (gameObject, 0.5f);
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
