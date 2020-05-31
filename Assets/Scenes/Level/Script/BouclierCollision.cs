using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouclierCollision : MonoBehaviour
{
    public DeleteAsteroid asteroid;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            print("Destruction asteroid by shield");

            asteroid = collider.gameObject.GetComponent<DeleteAsteroid>();
            asteroid.die();

            FindObjectOfType<HasBouclier>().breakShield();

            Destroy(gameObject);
        }
    }
}
