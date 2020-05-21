using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFusee : MonoBehaviour
{
    private Vector3 rotate;
    //public Transform player;

    // Update is called once per frame
    void Update() {
        if(Input.GetKey("f")) {
            rotate = new Vector3(0f, 0f, -0.5f);
            transform.Rotate(rotate);
        }
        if(Input.GetKey("q")) {
            rotate = new Vector3(0f, 0f, -0.3f);
            transform.Rotate(rotate);
        }
        if(Input.GetKey("j")) {
            rotate = new Vector3(0f, 0f, 0.3f);
            transform.Rotate(rotate);
        }
        if(Input.GetKey("m")) {
            rotate = new Vector3(0f, 0f, 0.5f);
            transform.Rotate(rotate);
        }
    }
}
