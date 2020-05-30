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
          
            asteroid = collider.gameObject.GetComponent<DeleteAsteroid>();
            asteroid.die();

            Destroy(gameObject);
        }
    }
}
