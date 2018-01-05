using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player; 

	private Vector3 focus; 

	void Start () 
	{
		focus = transform.position - player.transform.position;
	}


	void LateUpdate () 
	{

		transform.position = player.transform.position + focus;
	}
}
