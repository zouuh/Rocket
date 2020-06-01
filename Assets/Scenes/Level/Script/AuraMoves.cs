using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraMoves : MonoBehaviour
{
    public Transform parent;
    private Vector3 offset = new Vector3(0.0f, 0.1f, 0.0f);
    private Vector3 rotate = new Vector3(0.0f, 0.0f, 8.0f);


    // Update is called once per frame
    void Update()
    {
        transform.position = parent.position + offset;
        transform.Rotate(rotate);
    }
}
