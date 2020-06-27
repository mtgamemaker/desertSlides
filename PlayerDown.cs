using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDown : MonoBehaviour
{

    private PlatformEffector2D pe;

    float waitTime = 0.3f;
    bool startit = false;
    // Start is called before the first frame update
    void Start()
    {
        pe = GetComponent<PlatformEffector2D>();


    }

    // Update is called once per frame
    void Update()
    {
        /*
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    waitTime = 0.5f;
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    if (waitTime <= 0)
                    {
                        pe.rotationalOffset = 180f;
                        waitTime = 0.5f;
                    }
                    else
                    {
                        waitTime -= Time.deltaTime;
                    }
                }

                if (Input.GetKey(KeyCode.UpArrow))
                {
                    pe.rotationalOffset = 0.0f;
                }
        */

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pe.rotationalOffset = 180f;
            startit = true;
            FindObjectOfType<Jump>().playerJumpbtn2(1);
        }

        if (startit)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                pe.rotationalOffset = 0f;
                waitTime = 0.3f;
                startit = false;

            }

        }

        //      if (Input.GetKeyUp(KeyCode.DownArrow))
        //      {
        //          pe.rotationalOffset = 0.0f;
        //      }



    }





}
