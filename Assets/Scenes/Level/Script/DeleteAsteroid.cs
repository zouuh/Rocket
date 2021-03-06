﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAsteroid : MonoBehaviour
{
    public bool isDead = false;
    private float speed = 6.0f;
    private Rigidbody rb;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, 0));
        if (transform.position.y+10 < screenBounds.y || isDead)
        {
            Destroy(this.gameObject);
        }
    }

    public void die()
    {
        Destroy(this.gameObject);
    }
}
