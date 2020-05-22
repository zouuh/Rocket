using UnityEngine;
using UnityEngine.UI;

public class RocketCollision : MonoBehaviour
{

    public FuseeMoves movement;
    //public Text gameOverText;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            //gameOverText = true;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
