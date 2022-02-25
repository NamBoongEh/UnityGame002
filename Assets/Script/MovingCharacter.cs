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
    public float speed;

    Animator moveRnU;
    Animator moveLnD;

    void Start()
    {
        cha = GameObject.Find("Character");
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        pause = GameObject.Find("GameManager").GetComponent<GameScript>().pause;

        moveRnU = GetComponent<Animator>();
        moveLnD = GetComponent<Animator>();
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
            cha.transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
            MoveAni(false, true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            cha.transform.position += new Vector3(0f, -speed * Time.deltaTime, 0f);
            MoveAni(true, false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            cha.transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
            MoveAni(true, false);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            cha.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            MoveAni(false, true);
        }
        else if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveAni(false, false);
        }
    }

    void MoveAni(bool LnD, bool RnU)
    {
        moveLnD.SetBool("moveLnD", LnD);
        moveRnU.SetBool("moveRnU", RnU);
    }
}