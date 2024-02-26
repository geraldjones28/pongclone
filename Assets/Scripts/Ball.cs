using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    Vector2 direction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
    }

    private void FixedUpdate() {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Wall")) {
            direction.y = -direction.y;
        } else if (collision.gameObject.CompareTag("Paddle")) {
            direction.x = -direction.x;
        }
    }
}
