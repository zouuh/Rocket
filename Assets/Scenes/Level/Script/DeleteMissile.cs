using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMissile : MonoBehaviour
{
    private Vector3 screenBounds;

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, 0));
        if (transform.position.y + 10 < screenBounds.y || transform.position.y - 10 > screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
}
