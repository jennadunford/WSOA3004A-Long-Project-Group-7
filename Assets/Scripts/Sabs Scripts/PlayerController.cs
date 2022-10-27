using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Movement
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float runSpeed = 10.0f;
    bool isFacingRight = true;  
    public Rigidbody2D rigidbody2d;
    public bool isGrounded;
    public float jumpForce;





    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        isGrounded = true;
        jumpForce = 10;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {


        if (Input.GetKeyDown("space") )
        {
            // isGrounded = false;
            transform.Translate(new Vector3(0, jumpForce, 0) * Time.deltaTime);
        }

    }


    private void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * runSpeed, body.velocity.y);//dont change y velocity!!
        if (horizontal > 0 && !isFacingRight)
        {
            FlipCharcter();
        }
        else if (horizontal < 0 && isFacingRight)
        {
            FlipCharcter();
        }

    }

    void FlipCharcter()
    {
        Vector3 currScale = gameObject.transform.localScale;
        currScale.x *= -1;
        gameObject.transform.localScale = currScale;
        isFacingRight = !isFacingRight;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        //Debug.Log("Hi");
    }
}
