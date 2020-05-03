using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public int speed;
    public float startX;
    public float endX;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(transform.position.x < endX){
            transform.position = new Vector2(startX,transform.position.y);

        }
    }
}
