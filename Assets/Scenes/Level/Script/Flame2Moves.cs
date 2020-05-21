using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame2Moves : MonoBehaviour
{
    public Transform player;
	private Vector3 offset = new Vector3(-0.37f, -0.05f, 0.0f);
    private Vector3 scale;
    private Vector3 rotate;


    // Update is called once per frame
    void Update() {
        if(Input.GetKey("f")) {
            scale = new Vector3(0.13f, 0.15f, 0.15f);
        }
        else {
            scale = new Vector3(0f, 0f, 0f);
        }
        transform.position = player.position + offset;
        transform.localScale = scale; 
    }
}
