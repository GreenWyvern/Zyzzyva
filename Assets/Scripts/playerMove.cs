﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public float speed;
    private string direction = "up";
    
    Rigidbody2D rBody;

    // Use this for initialization
    void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        #region Move
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //this.GetComponent<Rigidbody2D>();


        rBody.velocity = movement * speed;
        #endregion
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.forward * -90);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.forward * 90);

        }
        */


    }
}