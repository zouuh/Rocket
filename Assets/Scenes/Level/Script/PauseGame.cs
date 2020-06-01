using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    private int count = 0;

    void Update()
    {
        if (FindObjectOfType<GameManager>().getGameHasBegin())
        {
            if (count < 10)
            {
                count++;
            }
            if (Input.GetKeyDown(KeyCode.Space) && count==10)
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
