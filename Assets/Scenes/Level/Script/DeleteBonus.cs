using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBonus : MonoBehaviour
{
    //public GameObject aura;
    private float speed = 6.0f;
    private Rigidbody rb;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        /*GameObject a = Instantiate(aura) as GameObject;
        a.transform.position = transform.position;*/
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, speed, 0);
/*        rbA = a.GetComponent<Rigidbody>();
        rbA.velocity = new Vector3(0, speed, 0);*/
    }

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, 0));
        if (transform.position.y + 10 < screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
}
