using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagedMonoBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Boot( Action returnCompletedAction)
    {

        returnCompletedAction();

    }
}
