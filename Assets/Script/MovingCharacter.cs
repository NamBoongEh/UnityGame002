using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovingCharacter : MonoBehaviour
{
    GameObject cha;
    float keydown = 0.01f;
    float nextKeydown = 0.0f;
    NavMeshAgent agent;
    bool pause;

    void Start()
    {
        cha = GameObject.Find("Character");
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        pause = GameObject.Find("GameManager").GetComponent<GameScript>().pause;
    }

    void Update()
    {
        if (!pause)
        {
            if (Time.time >= nextKeydown)
            {
                Keyboard();
                nextKeydown = Time.deltaTime + keydown;
            }
        }
    }

    void Keyboard()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cha.transform.Translate(0f, 0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cha.transform.Translate(0f, -0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cha.transform.Translate(-0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            cha.transform.Translate(0.01f, 0f, 0f);
        }
    }
}