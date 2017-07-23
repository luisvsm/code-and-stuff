using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript {


   public bool gameHasStarted;

    static GameControllerScript instance;
    public static GameControllerScript Instance
    

    {
        get
        {
            if (instance == null)
            {

                instance = new GameControllerScript();
                instance.gameHasStarted = false;

            }

            return instance;

        }
        set //Not used for singletons, typically.
        {

            instance = value;

        }

        
    }




}
