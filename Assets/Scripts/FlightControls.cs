﻿using UnityEngine;
using System.Collections;

public class FlightControls : MonoBehaviour {

    float xatstart = 0;
    float yatstart = 0;

    public float turnSpeed = 20f;

    private Vector3 Move;



    public float moveSpeed = 10f;
    private Quaternion localRotation; // 
   // public float speed = 1.0f; // ajustable speed from Inspector in Unity editor

    // Use this for initialization
    void Start ()
    {
        xatstart = Input.acceleration.x;
        yatstart = Input.acceleration.y;

        // copy the rotation of the object itself into a buffer
        localRotation = transform.rotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
       
        Debug.Log(Input.acceleration.y);
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);

        // find speed based on delta
        float curSpeed = Time.deltaTime * turnSpeed;
        // first update the current rotation angles with input from acceleration axis
        
       
        localRotation.x += (Input.acceleration.y) * curSpeed;
       
        
        localRotation.y += Input.acceleration.x * curSpeed;
       


        // then rotate this object accordingly to the new angle
        transform.rotation = localRotation;
        
    }
}
