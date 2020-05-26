using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    private Vector3 screenBounds;
    private float coordX = (float)Screen.width;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(asteroidWave());
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(coordX, Camera.main.transform.position.y, 0));
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-5, 5), screenBounds.y+20, 0);
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
