using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        Vector2 moveDirection = new Vector2(hInput * speed, rb.velocity.y);
        rb.velocity = moveDirection;
    }

}
