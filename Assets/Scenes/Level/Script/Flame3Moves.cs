using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame3Moves : MonoBehaviour
{
    public Transform player;
	private Vector3 offset = new Vector3(0.42f, -0.05f, 0.0f);
    private Vector3 apparition = new Vector3(0, 0, 0);


    // Update is called once per frame
    void Update() {
        if(Input.GetKey("j")) {
            apparition = new Vector3(0.13f, 0.15f, 0.15f);
        }
        else {
            apparition = new Vector3(0f, 0f, 0f);
        }
        transform.position = player.position + offset;
        transform.localScale = apparition;
    }
}
