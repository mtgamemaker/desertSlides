using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPlayer1 : MonoBehaviour
{



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(this.gameObject);
            //anim.SetInteger("playerState", 2);
            MyVars.stopMoving = 0;
        }
    }
}
