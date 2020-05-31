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

    private float loiNormale(float mu, float sigma) {
        float x = 0;
        float y = 1;
        float var = 0;
        while(y>var) {
            x = (float)Random.Range(-4, 4f);
            y = (float)Random.Range(0, 0.8f / ( Mathf.Sqrt(2*Mathf.PI*sigma) ));
            var = ( 1 / ( Mathf.Sqrt(2*Mathf.PI*sigma) ) ) * ( Mathf.Exp( -1f/2f*Mathf.Pow( 2,(x-mu) )/sigma ) );
        }
        return x;
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        float norm = loiNormale(0f, 1f);
        Debug.Log(norm);
        a.transform.position = new Vector3(norm + screenBounds.x, screenBounds.y+5, 0);
        a.transform.localScale = scale;
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            // PREMIERE VARIABLE ALEATOIRE : temps de respawn -> loi uniforme sur l'intervalle [0, 0.5]
            respawnTime = (float)Random.Range(0, 0.5f) + 0.6f;

            yield return new WaitForSeconds(respawnTime);
            if(FindObjectOfType<GameManager>().getGameHasBegin() && screenBounds.y > 15) {
                spawnEnemy();
            }
        }
    }
}
