using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployStar : MonoBehaviour
{
    public GameObject starPrefab;
    public float respawnTime = 1.0f;
    private Vector3 screenBounds;
    public GameObject stars;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(starWave());
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0));
    }

    private void spawnStars()
    {
        Vector3 position = new Vector3(Random.Range(screenBounds.x-100, screenBounds.x+100), Random.Range(screenBounds.y+40,screenBounds.y+60), Random.Range(30.0f, 100.0f));
        GameObject newStar = Instantiate(starPrefab, position, Quaternion.identity) as GameObject;
        newStar.transform.parent = stars.transform;
    }

    IEnumerator starWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            for (int i = 0; i < 10; i++)
            {
                spawnStars();
            }
        }
    }
}
