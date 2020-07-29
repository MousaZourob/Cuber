using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Side (R)")
        {
            rb.AddForce(-20, 0, 0, ForceMode.VelocityChange);
        }

        if (collisionInfo.collider.tag == "Side (L)")
        {
            rb.AddForce(20, 0, 0, ForceMode.VelocityChange);
        }
    }
}
