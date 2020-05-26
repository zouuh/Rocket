using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteStars : MonoBehaviour
{
    private Vector3 screenBounds;

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.transform.position.y, 0));
        if (transform.position.y + 50 < screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
}
