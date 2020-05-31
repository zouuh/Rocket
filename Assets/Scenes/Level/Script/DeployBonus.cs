using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBonus : MonoBehaviour
{
    public GameObject missilePrefab;
    public GameObject bouclierPrefab;
    public float respawnMissileTime = 8.32f;
    public float respawnBouclierTime = 3.0f;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(missileWave());
        StartCoroutine(bouclierWave());
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0));
    }

    private float loiTriangulaire(float a, float b, float c) {
        float x = 0;
        float y = 1;
        float var = 0;
        while(y>var) {
            x = (float)Random.Range(a, b);
            y = (float)Random.Range( 0, 2f/(b-a) );
            if(x < c) {
                var = (2 * (x - a)) / ( (b - a) * (c - a));
            }
            else {
                var = (2 * (b - x)) / ( (b - a) * (b - c));
            }
        }
        return x;
    }



    private void spawnMissile()
    {
        GameObject m = Instantiate(missilePrefab) as GameObject;
        m.transform.position = new Vector3(loiTriangulaire(-5, 5, 0), screenBounds.y + 10, 0);
    }

    private void spawnBouclier()
    {
        GameObject m = Instantiate(bouclierPrefab) as GameObject;
        m.transform.position = new Vector3(Random.Range(screenBounds.x - 5, screenBounds.x + 5), screenBounds.y + 15, 0);
    }

    IEnumerator missileWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnMissileTime);
            if (FindObjectOfType<GameManager>().getGameHasBegin() && !FindObjectOfType<GameManager>().getGameHasEnded() && screenBounds.y > 15)
            {
                spawnMissile();
            }
        }
    }

    IEnumerator bouclierWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnBouclierTime);
            if (FindObjectOfType<GameManager>().getGameHasBegin())
            {
                spawnBouclier();
            }
        }
    }
}
