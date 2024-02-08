using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public BallMovement movement;


    private void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
