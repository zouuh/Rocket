using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame1Move : MonoBehaviour
{
    public Transform player;
	private Vector3 offset = new Vector3(0.02f, -0.07f, 0.0f);
    private Vector3 apparition = new Vector3(0, 0, 0);


    // Update is called once per frame
    void Update() {
        if(!FindObjectOfType<GameManager>().getGameHasEnded()) {
        	transform.position = player.position + offset;        
        }
        else {
            transform.position = apparition;
        }
    }
}
