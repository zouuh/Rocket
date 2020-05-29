using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployMissile : MonoBehaviour
{
    public GameObject missilePrefab;
    public float respawnTime = 8.32f;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(missileWave());
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0));
    }

    private void spawnMissile()
    {
        GameObject m = Instantiate(missilePrefab) as GameObject;
        m.transform.position = new Vector3(Random.Range(screenBounds.x - 5, screenBounds.x + 5), screenBounds.y + 15, 0);
    }

    IEnumerator missileWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            if (FindObjectOfType<GameManager>().getGameHasBegin())
            {
                spawnMissile();
            }
        }
    }
}
