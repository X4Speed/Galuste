using UnityEngine;
[RequireComponent (typeof(Rigidbody2D))]
public class DamianJoaca : MonoBehaviour
{
    public float xViteza = 8f;
    
    float miscare = 0f;
    
    Rigidbody2D popcorn;
    void Start()
    {
        popcorn = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        miscare = Input.GetAxis("Horizontal") * xViteza ;
    }

    void FixedUpdate()
    {
        Vector2 velocity = popcorn.linearVelocity;
        velocity.x = miscare;
        popcorn.linearVelocity = velocity;
    }

}
