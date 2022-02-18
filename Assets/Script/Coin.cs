using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ø©±‚ ¥Í¿Ω");

        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("2D ø©±‚ ¥Í¿Ω");

        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("2D trigger ø©±‚ ¥Í¿Ω");

        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger ø©±‚ ¥Í¿Ω");

        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
