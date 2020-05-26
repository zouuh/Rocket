using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseeMoves : MonoBehaviour
{
	public Rigidbody rb;
    private float speed = 10.0f;
	private float sidewaysForce = 5f;

    void Update() {
        if(!FindObjectOfType<GameManager>().getGameHasEnded()) {
            rb.velocity = new Vector3(0, speed, 0);

            if (Input.GetKey("q")) {
                rb.velocity += new Vector3(sidewaysForce, 0, 0);
            }
            if(Input.GetKey("f")) {
                rb.velocity += new Vector3(sidewaysForce/2, 0, 0);
            }
            if(Input.GetKey("j")) {
                rb.velocity += new Vector3(-sidewaysForce/2, 0, 0);
            }
            if(Input.GetKey("m")) {
                rb.velocity += new Vector3(-sidewaysForce, 0, 0);
            }
        }
    }
}
