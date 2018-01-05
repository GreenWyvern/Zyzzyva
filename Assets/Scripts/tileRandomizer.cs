using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileRandomizer : MonoBehaviour {

    public Sprite altTile;

	// Use this for initialization
	void Start () {

        if (Random.Range(1, 3) == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = altTile;
        }

        transform.position = new Vector3(transform.position.x,transform.position.y, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
