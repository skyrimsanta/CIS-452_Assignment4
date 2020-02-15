/*
     * (Levi Schoof)
     * (GameManager)
     * (Assignment 4)
     * (Handles the Foundation of the Game)
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject results;

    public GameObject inGame;
    public GameObject instructions;

    private SimScript sim;
    bool currentPuaseState = true;

    private void Start()
    {
        OpenInstructions(true);
        currentPuaseState = true;
        sim = FindObjectOfType<SimScript>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenInstructions(currentPuaseState);
        }
    }

    public void MonsterDone()
    {
        menu.SetActive(false);
        results.SetActive(true);
        sim.RunSim();
    }

    public void OpenInstructions(bool open)
    {
        instructions.SetActive(open);
        inGame.SetActive(!open);

        currentPuaseState = !open;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }


}
