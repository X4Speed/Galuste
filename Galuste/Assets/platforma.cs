using UnityEngine;

public class platforma : MonoBehaviour
{
    public float salt = 10f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D popcorn = collision.collider.GetComponent<Rigidbody2D>();
        if (popcorn != null)
        {
            Vector2 velocity = popcorn.linearVelocity;
            velocity.y = salt;
            popcorn.linearVelocity = velocity;
        }
    }
}
