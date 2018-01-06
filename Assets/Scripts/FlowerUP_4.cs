using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerUP_4 : MonoBehaviour {

	public GameObject player;
	public GameObject bullet;


	// Use this for initialization
	void Start()
	{
		bullet.transform.localScale = new Vector3(10, 10, bullet.transform.position.z);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			//attempt to destroy game objject, or hide it once the buff has been picked up. Either case stops the coroutine.
			//  gameObject.SetActive(false);
			//  gameObject.GetComponent<Renderer>().enabled = false;
			bullet.transform.localScale = new Vector3(25, 25, bullet.transform.position.z);
			StartCoroutine(ScaleBuff());
		}

	}
	IEnumerator ScaleBuff()
	{
		yield return new WaitForSeconds(5);
		LowerScale();
		Destroy(gameObject);
	}

	void LowerScale()
	{
		bullet.transform.localScale = new Vector3(10, 10, bullet.transform.position.z);
	}
}