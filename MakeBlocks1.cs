using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlocks1 : MonoBehaviour
{
    public GameObject[] enemyObjList;
    int oldNum1;
    int oldNum2;

    int oldNum3;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("makeEnemy", 2);

        //InvokeRepeating("makeEnemy", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void makeEnemy()
    {

        int RandObj = Random.Range(0, enemyObjList.Length);

        oldNum1 = PlayerPrefs.GetInt("oldNum1");
        oldNum2 = PlayerPrefs.GetInt("oldNum2");
        oldNum3 = PlayerPrefs.GetInt("oldNum3");

        //print(RandObj + "--" + oldNum1 + "--" + oldNum2);

        while (RandObj == oldNum1 || RandObj == oldNum2 || RandObj == oldNum3)
        {
            RandObj = Random.Range(0, enemyObjList.Length);
        }

        PlayerPrefs.SetInt("oldNum1", RandObj);
        PlayerPrefs.SetInt("oldNum2", oldNum1);
        PlayerPrefs.SetInt("oldNum3", oldNum2);

        GameObject Enemy1 = Instantiate<GameObject>(enemyObjList[RandObj]);
        Enemy1.transform.position = new Vector2(transform.position.x, transform.position.y);

        print(RandObj + "---" + oldNum1 + "---" + oldNum2 + "---" + oldNum3);

    }
}

