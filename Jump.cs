using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

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

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(checkGround.position, feetRadius, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerJumpbtn();
        }
    }

    public void playerJumpbtn()
    {
        if (isGrounded)
        {
            rb.velocity = Vector2.up * jumpPower;

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(checkGround.position, feetRadius);
        //Gizmos.DrawSphere(checkGround.position, feetRadius);

    }

}
