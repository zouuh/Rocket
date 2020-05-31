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

    private float[] scales = new float[5];

    // Start is called before the first frame update
    void Start()
    {
        scales[0] = 0.4f;
        scales[1] = 0.5f;
        scales[2] = 0.6f;
        scales[3] = 0.7f;
        scales[4] = 0.8f;
        StartCoroutine(asteroidWave());
    }

    void Update() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0));
    }

    public float loiUniforme(float[] scales){
        int i;
        i = (int)Random.Range(0, scales.Length);
        return scales[i];
    }

    public float loiNormale(float mu, float sigma) {
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

    private void spawnEnemy() {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        float norm = loiNormale(0f, 1f);
        a.transform.position = new Vector3(norm + screenBounds.x, screenBounds.y+5, 0);

        scale = new Vector3(loiUniforme(scales), loiUniforme(scales), loiUniforme(scales));
        a.transform.localScale = scale;
    }

    IEnumerator asteroidWave() {
        while (true)
        {
            // PREMIERE VARIABLE ALEATOIRE : temps de respawn -> loi uniforme sur l'intervalle [0, 0.5]
            respawnTime = (float)Random.Range(0, 0.5f) + 0.6f;

            yield return new WaitForSeconds(respawnTime);
            if(FindObjectOfType<GameManager>().getGameHasBegin() && screenBounds.y > 20) {
                spawnEnemy();
            }
        }
    }
}
