using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame4Moves : MonoBehaviour
{
    public Transform player;
	private Vector3 offset = new Vector3(-0.63f, -0.04f, 0.0f);
    private Vector3 apparition = new Vector3(0, 0, 0);


    // Update is called once per frame
    void Update() {
        if(Input.GetKey("q")) {
            apparition = new Vector3(0.1f, 0.12f, 0.12f);
        }
        else {
            apparition = new Vector3(0f, 0f, 0f);
        }
        transform.position = player.position + offset;
        transform.localScale = apparition; 
    }
}
