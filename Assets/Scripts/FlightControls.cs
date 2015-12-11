using UnityEngine;
using System.Collections;

public class FlightControls : MonoBehaviour {

    float moveSpeed = 10f;
    private Quaternion localRotation; // 
    public float speed = 1.0f; // ajustable speed from Inspector in Unity editor

    // Use this for initialization
    void Start ()
    {
        // copy the rotation of the object itself into a buffer
        localRotation = transform.rotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Input.acceleration.y);
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);

        // find speed based on delta
        float curSpeed = Time.deltaTime * speed;
        // first update the current rotation angles with input from acceleration axis
        
       
        localRotation.x += (Input.acceleration.y) * curSpeed;
       
        
        localRotation.y += Input.acceleration.x * curSpeed;
       


        // then rotate this object accordingly to the new angle
        transform.rotation = localRotation;
    }
}
