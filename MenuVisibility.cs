using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuVisibility : MonoBehaviour {

    //Canvas Group Component Reference
    public CanvasGroup CG;

    //Scrollbar Reference
    public Scrollbar scroll;

    //Is our Target Menu Visible?
    public bool isVisible = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Show/Hide Menu Function
    public void ToggleVisibility()
    {
        //Check if the Menu is Currently Visible
        if(isVisible == false)
        {
            //If it Isn't, Set the Alpha to 1 so we can See it, Make it Interactable so we can Use it, Set the Scroll Value to 
            //1 so it Always Appears at the Top of the List, and Finally, Set the isVisible Variable to True, Because now it is Visible
            CG.alpha = 1;
            CG.interactable = true;
            scroll.value = 1;
            isVisible = true;
        }else
        {
            //If it is Visible, Set the Alpha to 0 to Hide it, Make it Not Interactable so we can't Use it, and Set the isVisible
            //Variable to False, Because now we can't See it
            CG.alpha = 0;
            CG.interactable = false;
            isVisible = false;
        }
    }
}
