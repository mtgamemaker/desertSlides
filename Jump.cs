using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Animator anim;
    public int jumpPower;

    public bool isGrounded = true;

    public Transform checkGround;

    public LayerMask whatIsGround;

    public float feetRadius;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(checkGround.position, feetRadius, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerJumpbtn();
        }

        if (isGrounded && MyVars.stopMoving == 1)
        {
            anim.SetInteger("playerState", 0);

        }
        else if (!isGrounded && MyVars.stopMoving == 1)
        {
            anim.SetInteger("playerState", 1);
        }
        else if (!isGrounded && MyVars.stopMoving == 0)
        {
            anim.SetInteger("playerState", 2);
        }
        else if (MyVars.stopMoving == 0)
        {
            anim.SetInteger("playerState", 2);
        }


    }

    public void playerJumpbtn()
    {
        if (isGrounded)
        {
            rb.velocity = Vector2.up * jumpPower;


        }
    }


    // i am using this to take the player down and calling it from another script
    public void playerJumpbtn2(int jmp1)
    {
        if (isGrounded)
        {
            rb.velocity = Vector2.up * jmp1;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(checkGround.position, feetRadius);
        //Gizmos.DrawSphere(checkGround.position, feetRadius);

    }

}
