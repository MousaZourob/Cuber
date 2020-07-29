using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            rb.AddForce(0, 0, 20, ForceMode.VelocityChange);
            FindObjectOfType<GameManager>().EndGame();
            ObstacleMovement.speed = 0f;
        }


        if (collisionInfo.collider.tag == "Side (R)")
        {
            rb.AddForce(-12, 0, 0, ForceMode.VelocityChange);
        }

        if (collisionInfo.collider.tag == "Side (L)")
        {
            rb.AddForce(12, 0, 0, ForceMode.VelocityChange);
        }
    }
}
