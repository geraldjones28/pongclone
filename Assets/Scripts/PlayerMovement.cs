using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    private void movePlayer() {
        var verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            rb.transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
        }
    }
}
