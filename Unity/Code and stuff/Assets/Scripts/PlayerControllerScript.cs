using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{

    public float health;

    private static PlayerControllerScript _instance;

    public static PlayerControllerScript Instance
    {

        get
        {

            if (_instance == null)
            {
                _instance = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
                _instance.health = 100f;
            }


            return _instance;

        }

    }

  
}

