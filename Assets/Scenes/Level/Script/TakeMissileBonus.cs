using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TakeMissileBonus : MonoBehaviour
{
    private bool bernoulli(float p) {
        float var = (float)Random.Range(0f, 1f);
        Debug.Log("Bernouilli " + (var<p) + " car var = " + var);
        return (var < p);
    }
    private int loiGeometrique(float p) {
        int nbBoucles = 1;
        while(nbBoucles < 10 && !bernoulli(p)) {

            nbBoucles++;
        }
        return nbBoucles;
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Missile Bonus taken");
            FindObjectOfType<ShootMissile>().addMissiles(loiGeometrique(0.6f));
            Destroy(gameObject);
        }
    }
}
