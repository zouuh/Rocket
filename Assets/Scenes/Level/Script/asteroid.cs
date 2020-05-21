﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed = 1000.0f;
    private Rigidbody rb;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
        rb.velocity=new Vector3(0, speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
}
