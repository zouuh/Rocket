﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeployBonus : MonoBehaviour
{
    public GameObject missilePrefab;
    public GameObject bouclierPrefab;
    public float respawnTime = 8.32f;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bonusWave());
    }

    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0));
    }

    private bool bernoulli(float p) {
        float var = (float)Random.Range(0f, 1f);
        return (var < p);
    }

    // private int binomiale(int n, float p) {
    //     int var = 0;
    //     for(int i=0; i<n; i++) {
    //         if(bernoulli(p)) {
    //             var++;
    //         }
    //     }
    //     return var;
    // }

    public int loiUniforme(){
        int var = (int)Random.Range(0, 3);
        return (var - 1) * 2;
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
        m.transform.position = new Vector3(loiTriangulaire(-5, 5, loiUniforme()) + screenBounds.x, screenBounds.y + 10, 0);
    }

    private void spawnBouclier()
    {
        GameObject b = Instantiate(bouclierPrefab) as GameObject;
        b.transform.position = new Vector3(Random.Range(loiTriangulaire(-5, 5, loiUniforme()) + screenBounds.x, screenBounds.x + 5), screenBounds.y + 10, 0);
    }


    IEnumerator bonusWave() {
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            if (FindObjectOfType<GameManager>().getGameHasBegin() && !FindObjectOfType<GameManager>().getGameHasEnded() && screenBounds.y > 20) {
                if(bernoulli(0.5f)) {
                    spawnMissile();
                }
                else {
                    if(!FindObjectOfType<HasBouclier>().hasBouclierBonus) {
                        spawnBouclier();
                    }
                    else{
                        Debug.Log("PAS DE BOUCLIER");
                    }
                }
            }
        }
    }
}
