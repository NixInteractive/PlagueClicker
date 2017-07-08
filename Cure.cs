using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cure : MonoBehaviour {

    //Referenced Scripts
    public GameManager GM;
    public StrainsManager Bac;
    public StrainsManager Vir;
    public StrainsManager Fun;
    public StrainsManager Pri;
    public StrainsManager Alg;
    public StrainsManager End;
    public StrainsManager Ect;
    public StrainsManager Nan;
    public StrainsManager Syn;

    //Max Value for the Cure Progress Bar
    public float maxVal = 120;

    //Cure Progress Bar
    public UnityEngine.UI.Slider cureBar;

    //Strain Progress Bars Influenced by the Cure
    public UnityEngine.UI.Slider BacBar;
    public UnityEngine.UI.Slider VirBar;
    public UnityEngine.UI.Slider FunBar;
    public UnityEngine.UI.Slider PriBar;
    public UnityEngine.UI.Slider AlgBar;
    public UnityEngine.UI.Slider EndBar;
    public UnityEngine.UI.Slider EctBar;
    public UnityEngine.UI.Slider NanBar;
    public UnityEngine.UI.Slider SynBar;
    

    // Use this for initialization
    void Start () {

        //Sets the Cure's Progress Bar's Max Value
        cureBar.maxValue = maxVal;
	}
	
	// Update is called once per frame
	void Update () {

        //Sets the Cure's Progress Bar Value to Equal the Cure Amount
        cureBar.value = GM.cure;

        //When the Cure Reaches Max Value
        if(GM.cure >= maxVal)
        {
            //Reset the Cure's Value
            GM.cure = 0;

            //Reduce the Total Number of Infections
            GM.infections = Mathf.Round(GM.infections * .1f);

            //Increase the Strain's Timers
            Bac.maxTime = Mathf.Round(Bac.maxTime * 1.1f);
            Vir.maxTime = Mathf.Round(Vir.maxTime * 1.15f);
            Fun.maxTime = Mathf.Round(Fun.maxTime * 1.2f);
            Pri.maxTime = Mathf.Round(Pri.maxTime * 1.25f);
            Alg.maxTime = Mathf.Round(Alg.maxTime * 1.3f);
            End.maxTime = Mathf.Round(End.maxTime * 1.35f);
            Ect.maxTime = Mathf.Round(Ect.maxTime * 1.4f);
            Nan.maxTime = Mathf.Round(Nan.maxTime * 1.45f);
            Syn.maxTime = Mathf.Round(Syn.maxTime * 1.5f);

            //Sets the Strain's Progress Bars to Match the Increased Times
            BacBar.maxValue = Bac.maxTime;
            VirBar.maxValue = Vir.maxTime;
            FunBar.maxValue = Fun.maxTime;
            PriBar.maxValue = Pri.maxTime;
            AlgBar.maxValue = Alg.maxTime;
            EndBar.maxValue = End.maxTime;
            EctBar.maxValue = Ect.maxTime;
            NanBar.maxValue = Nan.maxTime;
            SynBar.maxValue = Syn.maxTime;
        }
	}

}
