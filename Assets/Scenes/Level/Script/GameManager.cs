
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject gameOverUI;

    public float restartDelay = 5f;

    void Update() {
        if (gameHasEnded == true) {
            if (Input.GetKey("r")) {
                Restart();
            }
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

    

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
