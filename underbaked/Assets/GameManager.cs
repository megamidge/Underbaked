using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour {
public enum GameStates{
	startup,
	menu,
	inRound,
	betweenRound,
}

	public GameStates GameState{
        get {
            return gameState;
        }
		set{
			gameState = value;
		}
	}
	private GameStates gameState = GameStates.startup;
	// Use this for initialization
	void Start () {
		gameState = GameStates.menu;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameState == GameStates.inRound)
        {
            DoOrders();
        }
	}

    void DoOrders()
    {

    }
}
