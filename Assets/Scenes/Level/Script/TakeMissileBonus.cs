using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMissileBonus : MonoBehaviour
{

    public ShootMissile nbBullets;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Missile Bonus taken");
            FindObjectOfType<ShootMissile>().addFive();
            Destroy(gameObject);
        }
    }
}
