﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    public GameManager gameManager;
    public Canvas mainMenu;
    //public Text pointsText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mainMenu.gameObject.SetActive(gameManager.GameState == GameManager.GameStates.menu);
	}


    public void PlayButtonClick()
    {
        gameManager.GameState = GameManager.GameStates.inRound;
    }
}
