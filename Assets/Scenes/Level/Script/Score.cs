using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform rocket;
    public Text scoreValue;
    // Update is called once per frame
    void Update() {
        if(!FindObjectOfType<GameManager>().getGameHasEnded()) {
            scoreValue.text = (rocket.position.y - 6).ToString("0");
        }
    }
}
