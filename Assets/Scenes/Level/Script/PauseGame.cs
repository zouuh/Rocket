using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (FindObjectOfType<GameManager>().getGameHasBegin())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isPaused = !isPaused;
            }
            if (isPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
