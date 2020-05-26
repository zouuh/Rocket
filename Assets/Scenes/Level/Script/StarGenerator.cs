using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
   /* public GameObject star;
    public Transform player;
    public float respawnTime = 0.2f;
    private Vector3 position; 
    public GameObject stars;


    void Start() {
        StartCoroutine(starWave());   
    }

    private void spawnStars() {
   *//*     stars.name = "Stars";
        GameObject newStar;
        position = new Vector3(Random.Range(-50f, 50f), Random.Range(player.position.y + 50f, player.position.y + 70), Random.Range(30.0f, 100.0f));
        newStar = Instantiate(star, position, Quaternion.identity) as GameObject;
        newStar.transform.parent = stars.transform;*//*
    }

  *//*  IEnumerator<WaitForSeconds> starWave() {
        while(true) {
            yield return new WaitForSeconds(respawnTime);
            if(FindObjectOfType<GameManager>().getGameHasBegin()) {
                for(int i=0; i<10; i++) {
                    spawnStars();
                }
            }
        }
    }*/
}
