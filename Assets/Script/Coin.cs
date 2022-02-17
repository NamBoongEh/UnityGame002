using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("���� ����");

        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("2D ���� ����");

        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
