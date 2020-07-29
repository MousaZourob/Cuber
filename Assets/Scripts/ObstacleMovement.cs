using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    float forwardForce = -50f;

    public static float speed=0f;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            rb.AddForce(0, 0, forwardForce - speed, ForceMode.VelocityChange);
            speed = speed + 0.5f;
        }
    }

    void Update()
    {
        if (transform.position.z < 10f)
        {
            Destroy(gameObject);
        }
    }
}
