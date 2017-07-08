using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infect : MonoBehaviour {

    //GM Reference
    public GameManager GM;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //This is What Happens when the Player Hits the Infect Button
    public void InfectClick()
    {
        GM.infections += GM.ipc;
        GM.plaguePoints += GM.pppc;
    }
}
