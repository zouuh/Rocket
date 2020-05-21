using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoves : MonoBehaviour
{
    public Transform player;
	private Vector3 offset = new Vector3(0.0f, 1.0f, -2.5f);

    // Update is called once per frame
    void Update() {
        if(transform.position.y <= 20) {
    	    transform.position = player.position + offset; 
        }
        else if(transform.position.y < 40) {
            offset.y += (float)0.012;
            offset.z -= (float)0.03;
            transform.position = player.position + offset;
        } 
        else {
            offset.y = 2;
            offset.z = -5;
            transform.position = player.position + offset; 
        }  
    }
}
