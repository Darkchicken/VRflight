using UnityEngine;
using System.Collections;

public class FlightControls : MonoBehaviour {

    float xatstart = 0;
    float yatstart = 0;

    public float turnSpeed = 20f;

    private Vector3 Move;
    GameObject head; 


    public float moveSpeed = 10f;
    private Quaternion localRotation; // 
   // public float speed = 1.0f; // ajustable speed from Inspector in Unity editor

    // Use this for initialization
    void Start ()
    {
        head = GameObject.Find("Head");
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
        //this allows the ship to go in the direction you face
        // transform.Translate(head.transform.forward * moveSpeed * Time.deltaTime);



    }
}
