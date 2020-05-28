using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(screenBounds.x-5, screenBounds.x+5), screenBounds.y+15, 0); 
        a.transform.localScale = scale;
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            if(FindObjectOfType<GameManager>().getGameHasBegin()) {
                spawnEnemy();
            }
        }
    }
}
