using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMechanics3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			SceneManager.LoadScene ("End");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
