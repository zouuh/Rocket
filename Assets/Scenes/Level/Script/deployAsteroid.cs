using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeployAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    private Vector3 screenBounds;
    private Vector3 scale;

    private float var;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(asteroidWave());
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0));
        scale = new Vector3(Random.Range(0.4f, 0.8f), Random.Range(0.4f, 0.8f), Random.Range(0.4f, 0.8f));
    }

    private float loiBinomiale(int n, float p) {
        var = 0;
        for(int i=0; i<n; i++) {
            float rand = (float)Random.Range(0, 1f);
            if(rand > p) {
                var++;
            }
        }
        return var/10;
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(loiBinomiale(100, 0.5f) + screenBounds.x - 5, screenBounds.y+10, 0);
        a.transform.localScale = scale;
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            // PREMIERE VARIABLE ALEATOIRE : temps de respawn -> loi uniforme sur l'intervalle [0, 0.5]
            respawnTime = (float)Random.Range(0, 0.5f) + 0.6f;

            yield return new WaitForSeconds(respawnTime);
            if(FindObjectOfType<GameManager>().getGameHasBegin()) {
                spawnEnemy();
            }
        }
    }
}
