using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollision : MonoBehaviour
{
    public DeleteAsteroid asteroid;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            print("Destruction asteroid");
            print(collider.gameObject.name);
            FindObjectOfType<DeleteAsteroid>().die();
            /*asteroid = GetComponent<DeleteAsteroid>();
            asteroid.isDead = true;*/
            Destroy(gameObject);
        }
    }
}
