using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject[] goal;
    public bool[] goalSwitch = new bool[4];
    GameObject cha;

    private void Awake()
    {
        for (int i = 0; i < 4; i++)
            goalSwitch[i] = true;
    }

    private void Start()
    {
        cha = GameObject.Find("Character");
    }

    private void Update()
    {
        //9½Ã °ñ À§Ä¡
        if ((cha.transform.position.x <= -16.7 && cha.transform.position.x >= -17.5) && (cha.transform.position.y <= -0.75 && cha.transform.position.y >= -2.6) && goalSwitch[0])
            RemoveGoal(0);
        //12½Ã °ñ À§Ä¡
        else if ((cha.transform.position.x >= -15.4 && cha.transform.position.x <= -14.43) && (cha.transform.position.y <= 10 && cha.transform.position.y >= 9.85) && goalSwitch[1])
            RemoveGoal(1);
        //2½Ã °ñ À§Ä¡
        else if ((cha.transform.position.x <= 11.87 && cha.transform.position.x >= 10.56) && (cha.transform.position.y <= 9.95 && cha.transform.position.y >= 9.75) && goalSwitch[2])
            RemoveGoal(2);
        //5½Ã °ñ À§Ä¡
        else if ((cha.transform.position.x <= 0.24 && cha.transform.position.x >= -0.95) && (cha.transform.position.y <= -3.49 && cha.transform.position.y >= -4.01) && goalSwitch[3])
            RemoveGoal(3);
    }

    public void RemoveGoal(int num)
    {
        Debug.Log("°ñ Áö¿öÁø´Ù  :  " + num);
        Destroy(goal[num]);
        goalSwitch[num] = false;
    }
}