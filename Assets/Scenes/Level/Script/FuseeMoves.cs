using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseeMoves : MonoBehaviour
{
    //Ref to rigidBody
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

    // Fixed is beacause we are using it to mess with physics
    void FixedUpdate() {
    	//Add forward force
        rb.AddForce(0, forwardForce * Time.deltaTime/4, 0);

        if(Input.GetKey("q")) {
        	rb.AddForce(sidewaysForce * Time.deltaTime/2, 0, 0);
        }
       	if(Input.GetKey("f")) {
        	rb.AddForce((sidewaysForce * Time.deltaTime)/3, 0, 0);
        }
        if(Input.GetKey("j")) {
        	rb.AddForce(-(sidewaysForce * Time.deltaTime)/3, 0, 0);
        }
        if(Input.GetKey("m")) {
        	rb.AddForce(-sidewaysForce * Time.deltaTime/2, 0, 0);
        }
    }
}
