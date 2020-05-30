using UnityEngine;
using UnityEngine.UI;

public class RocketCollision : MonoBehaviour
{

    public FuseeMoves movement;

   public FuseeMoves movement;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
