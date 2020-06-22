using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePlayerDown : MonoBehaviour
{
    private PlatformEffector2D pf;

    float waitTime = 0.5f;

    bool goingDown = false;

    // Start is called before the first frame update
    void Start()
    {
        pf = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pf.rotationalOffset = 180f;
            goingDown = true;
        }

        if (goingDown)
        {
            waitTime -= Time.deltaTime;

            if (waitTime <= 0)
            {
                pf.rotationalOffset = 0f;
                goingDown = false;
                waitTime = 0.5f;
            }
        }
    }
}
