using UnityEngine;
using UnityEngine.UI;

public class NumberMissiles : MonoBehaviour
{
    public Text nbMissiles;
    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<GameManager>().getGameHasEnded())
        {
            nbMissiles.text = (FindObjectOfType<ShootMissile>().nbMissile).ToString();
        }
    }
}
