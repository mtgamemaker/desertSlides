using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMove : MonoBehaviour
{
    public int speedBoost;  // set this to 5
    public float jumpSpeed; // set this to 600

    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator anim;
    bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerSpeed = Input.GetAxisRaw("Horizontal"); // value will be 1, -1 or 0
        playerSpeed *= speedBoost;

        if (playerSpeed != 0)
            MoveHorizontal(playerSpeed);
        else
            StopMoving();

        if (Input.GetButtonDown("Jump"))
            Jump();


    }

    void MoveHorizontal(float playerSpeed)
    {
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y);

        anim.SetInteger("StatePlayer", 1);

        if (playerSpeed < 0)
            sr.flipX = true;
        else if (playerSpeed > 0)
            sr.flipX = false;

        //if (!isJumping)
        //    anim.SetInteger("State", 1);
    }

    void StopMoving()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        anim.SetInteger("StatePlayer", 0);

        //if (!isJumping)
        //    anim.SetInteger("State", 0);
    }



    void Jump()
    {

        isJumping = true;
        rb.AddForce(new Vector2(0, jumpSpeed));
        //anim.SetInteger("State", 2);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isJumping = false;
    }
}
