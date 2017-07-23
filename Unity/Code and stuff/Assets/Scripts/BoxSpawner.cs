using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : ManagedMonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CheckIfGameHasStarted()
    {


        if (GameControllerScript.Instance.gameHasStarted)
        {
            Debug.Log("The game is on!");
        }
    }

    public override void  Boot(Action returnCompletedAction)
    {

        GameControllerScript.Instance = new GameControllerScript();
        returnCompletedAction();

    }
}
