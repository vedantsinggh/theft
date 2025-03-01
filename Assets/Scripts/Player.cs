using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    [System.Obsolete]
    void Update()
    {
        Vector2 velocity = rb.velocity;

        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity.x = moveSpeed;
        }
        else
        {
            velocity.x = 0; 
        }

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f) 
        {
            velocity.y = jumpForce; 
        }

        rb.velocity = velocity;
    }

}
 