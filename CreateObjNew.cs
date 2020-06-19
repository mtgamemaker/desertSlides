using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjNew : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MakeObj")
        {
            FindObjectOfType<MakeBlocks1>().makeEnemy();

        }
    }
}
