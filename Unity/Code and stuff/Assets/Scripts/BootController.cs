using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootController : MonoBehaviour {

	public ManagedMonoBehaviour[] bootList = new ManagedMonoBehaviour[0];

    int haveBootedCallbacks;
    
    void Start() {

        haveBootedCallbacks = 0;

        for (int i = 0; i < bootList.Length; i++)
                {

                     bootList[i].Boot(IterateBootedCallBacks);

                }

	}

    void IterateBootedCallBacks()
    {

        haveBootedCallbacks++;
        CheckIfBooted();

    }

    void CheckIfBooted()
    {

        if (haveBootedCallbacks == bootList.Length)
        {

            StartGame();

        }

    }

    void StartGame()
    {

        GameControllerScript.Instance.gameHasStarted = true;
        PlayerControllerScript.Instance.health = 100f;
        Debug.Log("And yet it moves");

    }
}
