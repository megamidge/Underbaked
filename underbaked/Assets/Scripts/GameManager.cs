﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int Points = 0;

    public enum GameStates
    {
        startup,
        menu,
        inRound,
        betweenRound,
    }

    public GameStates GameState
    {
        get
        {
            return gameState;
        }
        set
        {
            gameState = value;
        }
    }
    private GameStates gameState = GameStates.startup;
    // Use this for initialization
    void Start()
    {
        gameState = GameStates.menu;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
