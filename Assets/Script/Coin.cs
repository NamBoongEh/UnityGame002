using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject[] coin;
    public bool[] coinSwitch = new bool[27];
    GameObject cha;

    private void Awake()
    {
        for (int i = 0; i < 27; i++)
            coinSwitch[i] = true;
    }

    private void Start()
    {
        cha = GameObject.Find("Character");
    }

    private void Update()
    {
        //코인 위치
        if ((cha.transform.position.x <= -2.47 && cha.transform.position.x >= -3.7) && (cha.transform.position.y <= -0.17 && cha.transform.position.y >= -1.61) && coinSwitch[0])
            RemoveCoin(0);
        if ((cha.transform.position.x <= -17.38 && cha.transform.position.x >= -17.5) && (cha.transform.position.y <= 9.95 && cha.transform.position.y >= 9.16) && coinSwitch[1])
            RemoveCoin(1);
        if ((cha.transform.position.x <= -1.1 && cha.transform.position.x >= -1.61) && (cha.transform.position.y <= 8.2 && cha.transform.position.y >= 7.75) && coinSwitch[2])
            RemoveCoin(2);
        if ((cha.transform.position.x <= -1.2 && cha.transform.position.x >= -2) && (cha.transform.position.y <= 8.08 && cha.transform.position.y >= 8.06) && coinSwitch[3])
            RemoveCoin(3);
        if ((cha.transform.position.x <= 2.42 && cha.transform.position.x >= 1.2) && (cha.transform.position.y <= 10.4 && cha.transform.position.y >= 10.1) && coinSwitch[4])
            RemoveCoin(4);
        if ((cha.transform.position.x <= 7.5 && cha.transform.position.x >= 6.3) && (cha.transform.position.y <= 9.32 && cha.transform.position.y >= 9.27) && coinSwitch[5])
            RemoveCoin(5);
        if ((cha.transform.position.x <= 4.16 && cha.transform.position.x >= 3.32) && (cha.transform.position.y <= 5.1 && cha.transform.position.y >= 4.33) && coinSwitch[6])
            RemoveCoin(6);
        if ((cha.transform.position.x <= 5.4 && cha.transform.position.x >= 4.25) && (cha.transform.position.y <= 5.1 && cha.transform.position.y >= 4.33) && coinSwitch[7])
            RemoveCoin(7);
        if ((cha.transform.position.x <= 6.2 && cha.transform.position.x >= 5.5) && (cha.transform.position.y <= 5.1 && cha.transform.position.y >= 4.33) && coinSwitch[8])
            RemoveCoin(8);
        if ((cha.transform.position.x <= 15.44 && cha.transform.position.x >= 14.26) && (cha.transform.position.y <= 6.2 && cha.transform.position.y >= 5.79) && coinSwitch[9])
            RemoveCoin(9);
        if ((cha.transform.position.x <= 11.24 && cha.transform.position.x >= 10.55) && (cha.transform.position.y <= -6.5 && cha.transform.position.y >= -7.23) && coinSwitch[10])
            RemoveCoin(10);
        if ((cha.transform.position.x <= 4.28 && cha.transform.position.x >= 3.33) && (cha.transform.position.y <= 2.53 && cha.transform.position.y >= 1.77) && coinSwitch[11])
            RemoveCoin(11);
        if ((cha.transform.position.x <= 10.83 && cha.transform.position.x >= 10.49) && (cha.transform.position.y <= -0.33 && cha.transform.position.y >= -1.69) && coinSwitch[12])
            RemoveCoin(12);
        if ((cha.transform.position.x <= 7.18 && cha.transform.position.x >= 6.16) && (cha.transform.position.y <= -5.4 && cha.transform.position.y >= -6.35) && coinSwitch[13])
            RemoveCoin(13);
        if ((cha.transform.position.x <= 7.18 && cha.transform.position.x >= 6.16) && (cha.transform.position.y <= -6.26 && cha.transform.position.y >= -7.22) && coinSwitch[14])
            RemoveCoin(14);
        if ((cha.transform.position.x <= 8.82 && cha.transform.position.x >= 7.67) && (cha.transform.position.y <= -9.07 && cha.transform.position.y >= -9.8) && coinSwitch[15])
            RemoveCoin(15);
        if ((cha.transform.position.x <= 3.98 && cha.transform.position.x >= 3.13) && (cha.transform.position.y <= -9.06 && cha.transform.position.y >= -9.76) && coinSwitch[16])
            RemoveCoin(16);
        if ((cha.transform.position.x <= 1.45 && cha.transform.position.x >= 0.91) && (cha.transform.position.y <= -4.35 && cha.transform.position.y >= -5.71) && coinSwitch[17])
            RemoveCoin(17);
        if ((cha.transform.position.x <= -2.77 && cha.transform.position.x >= -3.86) && (cha.transform.position.y <= -6.8 && cha.transform.position.y >= -7.65) && coinSwitch[18])
            RemoveCoin(18);
        if ((cha.transform.position.x <= -11.5 && cha.transform.position.x >= -12.5) && (cha.transform.position.y <= -4.36 && cha.transform.position.y >= -4.94) && coinSwitch[19])
            RemoveCoin(19);
        if ((cha.transform.position.x <= -14.15 && cha.transform.position.x >= -15.07) && (cha.transform.position.y <= -2.63 && cha.transform.position.y >= -3.98) && coinSwitch[20])
            RemoveCoin(20);
        if ((cha.transform.position.x <= -10.06 && cha.transform.position.x >= -10.82) && (cha.transform.position.y <= 1.91 && cha.transform.position.y >= 1.13) && coinSwitch[21])
            RemoveCoin(21);
        if ((cha.transform.position.x <= -11.05 && cha.transform.position.x >= -12.2) && (cha.transform.position.y <= -6.75 && cha.transform.position.y >= -7.66) && coinSwitch[22])
            RemoveCoin(22);
        if ((cha.transform.position.x <= -10.33 && cha.transform.position.x >= -11.1) && (cha.transform.position.y <= 5.63 && cha.transform.position.y >= 5.27) && coinSwitch[23])
            RemoveCoin(23);
        if ((cha.transform.position.x <= -5.63 && cha.transform.position.x >= -6.43) && (cha.transform.position.y <= 6.25 && cha.transform.position.y >= 5.41) && coinSwitch[24])
            RemoveCoin(24);
        if ((cha.transform.position.x <= -3.45 && cha.transform.position.x >= -3.9) && (cha.transform.position.y <= 6.02 && cha.transform.position.y >= 4.67) && coinSwitch[25])
            RemoveCoin(25);
        if ((cha.transform.position.x <= 17.57 && cha.transform.position.x >= 17.17) && (cha.transform.position.y <= -9.09 && cha.transform.position.y >= -9.98) && coinSwitch[26])
            RemoveCoin(26);
    }

    public void RemoveCoin(int num)
    {
        Debug.Log("코인 지워진다  :  " + num);
        Destroy(coin[num]);
        coinSwitch[num] = false;
    }
}