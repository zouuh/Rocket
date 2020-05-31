using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBouclierBonus : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Bouclier Bonus taken");
            FindObjectOfType<HasBouclier>().addBouclier();
            Destroy(gameObject);
        }
    }
}
