using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCharacter : MonoBehaviour
{
    float keydown = 0.01f;
    float nextKeydown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextKeydown)
        {
            Keyboard();
            nextKeydown = Time.time + keydown;
        }
    }

    void Keyboard()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0f, 0.1f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0f, -0.1f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.1f, 0f, 0f);
        }
    }
}