using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMissileBonus : MonoBehaviour
{
    private int loiGeometrique(float lambda) {
        return 1;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Missile Bonus taken");
            FindObjectOfType<ShootMissile>().addMissiles(5);
            Destroy(gameObject);
        }
    }
}
