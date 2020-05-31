using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissile : MonoBehaviour
{
    public GameObject missile;
    public int nbMissile = 5;
    private float speed = 22.0f;
    private Rigidbody rb;
    private Vector3 screenBounds;

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, 0));
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (nbMissile == 0)
            {
                print("No more bullets");
            }
            else
            {
                print("Shooting !");
                nbMissile-=1;
                GameObject instMissile = Instantiate(missile) as GameObject;
                instMissile.transform.position = new Vector3(transform.position.x - 0.68f, transform.position.y - 4.5f, 0);
                instMissile.transform.localScale = new Vector3(0.0003f, 0.0003f, 0.0003f);
                rb = instMissile.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(0, speed, 0);
            }
        }
    }

    public void addMissiles(int nb)
    {
        nbMissile += nb;
        print(nb + " munissions supplémentaires");
        print(nbMissile);
    }
}
