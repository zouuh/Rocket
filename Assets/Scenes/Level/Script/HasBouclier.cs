using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasBouclier : MonoBehaviour
{
    public GameObject bouclier;
    private bool takeBouclierBonus = false;
    public bool hasBouclierBonus = false;
    private float speed;
    private Rigidbody rb;
    private GameObject instBouclier;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().getGameHasBegin())
        {
            speed = FindObjectOfType<FuseeMoves>().speed;

            if (takeBouclierBonus)
            {
                print("You are protected");
                instBouclier = Instantiate(bouclier) as GameObject;
                instBouclier.transform.position = new Vector3(transform.position.x - 0.68f, transform.position.y - 5.15f, 0);
                rb = instBouclier.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(0, speed, 0);
                takeBouclierBonus = false;
                hasBouclierBonus = true;
            }

            if (hasBouclierBonus)
            {
                instBouclier.transform.position = new Vector3(transform.position.x - 0.68f, transform.position.y - 5.15f, 0);
                rb = instBouclier.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(0, speed, 0);
            }
        }
    }

    public void addBouclier()
    {
        takeBouclierBonus = true;
    }
}
