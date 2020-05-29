using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMissileBonus : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Missile Bonus taken");
            Destroy(gameObject);
        }
    }
}
