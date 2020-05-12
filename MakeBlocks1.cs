using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlocks1 : MonoBehaviour
{
    public GameObject[] enemyObjList;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeEnemy", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void makeEnemy()
    {
        int RandObj = Random.Range(0, enemyObjList.Length);
        GameObject Enemy1 = Instantiate<GameObject>(enemyObjList[RandObj]);

        Enemy1.transform.position = new Vector2(transform.position.x, transform.position.y);

    }
}
