using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Vector3 cha;

    private void Start()
    {
        cha = GameObject.Find("Character").transform.position;

    }

    private void FixedUpdate()
    {
        Debug.Log("포지션은  : " + cha);

        if((cha.x <= -2.65 && cha.x >= -3.5) && (cha.z <= -0.1 && cha.z >= -1.4))
        {
            Debug.Log("동전에 닿았다");
        }
    }
}