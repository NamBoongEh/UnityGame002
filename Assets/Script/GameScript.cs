using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public bool pause = false;
    float timer;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
            Application.Quit();
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(0);
        if (Input.GetKey(KeyCode.Space))
        {
            if (!pause)
            {
                Time.timeScale = 0;
                pause = true;
            }
            else
            {
                Time.timeScale = 1;
                pause = false;
            }
        }

        timer = timer + Time.deltaTime;
        Debug.Log(string.Format(timer + ""));

    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
