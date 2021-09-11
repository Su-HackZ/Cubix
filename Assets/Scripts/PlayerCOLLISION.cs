using UnityEngine;

public class PlayerCOLLISION : MonoBehaviour
{
    public PlayerMovement movement;
     void OnCollisionEnter(Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
