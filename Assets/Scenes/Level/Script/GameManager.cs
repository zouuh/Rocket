
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasBegin = false;
    bool gameHasEnded = false;
    public GameObject gameOverUI;
    public GameObject gameStartUI;
    public GameObject gamePauseUI;
    public FuseeMoves movement;


    void Update() {
        if (Input.GetKey("space")) {
            gameHasBegin = true;
        }
        if (gameHasBegin) {
            gameStartUI.SetActive(false);
            movement.enabled = true;
        }
        if (gameHasEnded) {
            if (Input.GetKey("r")) {
                Restart();
            }
        }
        if (FindObjectOfType<PauseGame>().isPaused && !gameHasEnded) {
            gamePauseUI.SetActive(true);
        }
        else {
            gamePauseUI.SetActive(false);
        }
    }
    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded =true;
            Debug.Log("GAME OVER");
            gameOverUI.SetActive(true);
        }
        if (Input.GetKey("r")){
            Restart();
        }
    }

    public bool getGameHasBegin() {
        return gameHasBegin;
    }

    public bool getGameHasEnded() {
        return gameHasEnded;
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
