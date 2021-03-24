using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 0.0f;

    AudioSource audioSource;
    Vector2 startPos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = transform.position;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - startPos.x);

            this.moveSpeed = swipeLength / 500.0f;
            audioSource.Play();
        }

        moveSpeed *= 0.98f;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * moveSpeed, ForceMode2D.Impulse);
    }
}
