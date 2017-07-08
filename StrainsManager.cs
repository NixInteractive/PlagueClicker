using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StrainsManager : MonoBehaviour
{
    //GM Reference
    public GameManager GM;
    
    //UI Elements on our Button
    public Text levelDisp;
    public Text costDisp;
    public Text IPSDisp;
    public Slider strainBar;

    //# of Times the Player has Purchased the Strain
    public int level;

    //Strain Progress Bar Value
    public int time;

    //Time Until Strain Triggers
    public float maxTime;

    //Amount the Cost and Infections Bonus Increase Upon Purchasing Another Strain
    public float costMod;
    public float infectMod;

    //Cost to Purchase
    public float cost;

    //Amount of Infections Added When the Strain Triggers
    public float IPSAdd;

    // Use this for initialization
    void Start()
    {
        //Starts the Function that Fills the Progress Bars
        StartCoroutine(AutoTick());

        //Sets the Max Value for the Strain's Progress Bar
        strainBar.maxValue = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //Updates the Max Value on the Strain's Progress Bars for When the Cure is Triggered
        strainBar.maxValue = maxTime;

        //Level #'s
        if (level >= Mathf.Pow(10, 3))
        {
            if (level >= Mathf.Pow(10, 6))
            {
                if (level >= Mathf.Pow(10, 9))
                {
                    if (level >= Mathf.Pow(10, 12))
                    {
                        if (level >= Mathf.Pow(10, 15))
                        {
                            if (level >= Mathf.Pow(10, 18))
                            {
                                if (level >= Mathf.Pow(10, 21))
                                {
                                    if (level >= Mathf.Pow(10, 24))
                                    {
                                        if (level >= Mathf.Pow(10, 27))
                                        {
                                            if (level >= Mathf.Pow(10, 30))
                                            {
                                                levelDisp.text = "Lvl: " + (level * 0.000000000000000000000000000001).ToString("#.0") + "N";
                                            }
                                            else
                                            {
                                                levelDisp.text = "Lvl: " + (level * 0.000000000000000000000000001).ToString("#.0") + "O";
                                            }
                                        }
                                        else
                                        {
                                            levelDisp.text = "Lvl: " + (level * 0.000000000000000000000001).ToString("#.0") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        levelDisp.text = "Lvl: " + (level * 0.000000000000000000001).ToString("#.0") + "Sx";
                                    }
                                }
                                else
                                {
                                    levelDisp.text = "Lvl: " + (level * 0.000000000000000001).ToString("#.0") + "Qi";
                                }
                            }
                            else
                            {
                                levelDisp.text = "Lvl: " + (level * 0.000000000000001).ToString("#.0") + "Qa";
                            }
                        }
                        else
                        {
                            levelDisp.text = "Lvl: " + (level * 0.000000000001).ToString("#.0") + "T";
                        }
                    }
                    else
                    {
                        levelDisp.text = "Lvl: " + (level * 0.000000001).ToString("#.0") + "B";
                    }
                }
                else
                {
                    levelDisp.text = "Lvl: " + (level * 0.000001f).ToString("#.0") + "M";
                }
            }
            else
            {
                levelDisp.text = "Lvl: " + (level * 0.001f).ToString("#.0") + "K";
            }
        }
        else
        {
            levelDisp.text = "Lvl: " + level;
        }

        //Cost #'s
        if (cost >= Mathf.Pow(10, 3))
        {
            if (cost >= Mathf.Pow(10, 6))
            {
                if (cost >= Mathf.Pow(10, 9))
                {
                    if (cost >= Mathf.Pow(10, 12))
                    {
                        if (cost >= Mathf.Pow(10, 15))
                        {
                            if (cost >= Mathf.Pow(10, 18))
                            {
                                if (cost >= Mathf.Pow(10, 21))
                                {
                                    if (cost >= Mathf.Pow(10, 24))
                                    {
                                        if (cost >= Mathf.Pow(10, 27))
                                        {
                                            if (cost >= Mathf.Pow(10, 30))
                                            {
                                                costDisp.text = "Cost: " + (cost * 0.000000000000000000000000000001).ToString("#.0") + "N";
                                            }
                                            else
                                            {
                                                costDisp.text = "Cost: " + (cost * 0.000000000000000000000000001).ToString("#.0") + "O";
                                            }
                                        }
                                        else
                                        {
                                            costDisp.text = "Cost: " + (cost * 0.000000000000000000000001).ToString("#.0") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        costDisp.text = "Cost: " + (cost * 0.000000000000000000001).ToString("#.0") + "Sx";
                                    }
                                }
                                else
                                {
                                    costDisp.text = "Cost: " + (cost * 0.000000000000000001).ToString("#.0") + "Qi";
                                }
                            }
                            else
                            {
                                costDisp.text = "Cost: " + (cost * 0.000000000000001).ToString("#.0") + "Qa";
                            }
                        }
                        else
                        {
                            costDisp.text = "Cost: " + (cost * 0.000000000001).ToString("#.0") + "T";
                        }
                    }
                    else
                    {
                        costDisp.text = "Cost: " + (cost * 0.000000001).ToString("#.0") + "B";
                    }
                }
                else
                {
                    costDisp.text = "Cost: " + (cost * 0.000001f).ToString("#.0") + "M";
                }
            }
            else
            {
                costDisp.text = "Cost: " + (cost * 0.001f).ToString("#.0") + "K";
            }
        }
        else
        {
            costDisp.text = "Cost: " + cost;
        }

        //IPSAdd #'s
        if (IPSAdd >= Mathf.Pow(10, 3))
        {
            if (IPSAdd >= Mathf.Pow(10, 6))
            {
                if (IPSAdd >= Mathf.Pow(10, 9))
                {
                    if (IPSAdd >= Mathf.Pow(10, 12))
                    {
                        if (IPSAdd >= Mathf.Pow(10, 15))
                        {
                            if (IPSAdd >= Mathf.Pow(10, 18))
                            {
                                if (IPSAdd >= Mathf.Pow(10, 21))
                                {
                                    if (IPSAdd >= Mathf.Pow(10, 24))
                                    {
                                        if (IPSAdd >= Mathf.Pow(10, 27))
                                        {
                                            if (IPSAdd >= Mathf.Pow(10, 30))
                                            {
                                                IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000000000000000000000001).ToString("#.0") + "N";
                                            }
                                            else
                                            {
                                                IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000000000000000000001).ToString("#.0") + "O";
                                            }
                                        }
                                        else
                                        {
                                            IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000000000000000001).ToString("#.0") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000000000000001).ToString("#.0") + "Sx";
                                    }
                                }
                                else
                                {
                                    IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000000000001).ToString("#.0") + "Qi";
                                }
                            }
                            else
                            {
                                IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000000001).ToString("#.0") + "Qa";
                            }
                        }
                        else
                        {
                            IPSDisp.text = "Infect: " + (IPSAdd * 0.000000000001).ToString("#.0") + "T";
                        }
                    }
                    else
                    {
                        IPSDisp.text = "Infect: " + (IPSAdd * 0.000000001).ToString("#.0") + "B";
                    }
                }
                else
                {
                    IPSDisp.text = "Infect: " + (IPSAdd * 0.000001f).ToString("#.0") + "M";
                }
            }
            else
            {
                IPSDisp.text = "Infect: " + (IPSAdd * 0.001f).ToString("#.0") + "K";
            }
        }
        else
        {
            IPSDisp.text = "Infect: " + IPSAdd;
        }

        //Stops the Progress Bars from Filling if the Player Hasn't Purchased a Strain
        if (level <= 0)
        {
            time = 0;
        }

        //Sets the Strain's Progress Bar's Value to Equal the Time Value
        strainBar.value = time;

        //When the Progress Bar is Full, This Adds the IPSAdd Value to the Total Number of Infections
        if (time >= maxTime)
        {
            GM.infections += IPSAdd;
            time = 0;
            GM.score += 1;
        }
    }

    //This is What Happens when the Player Presses the Strain's Button
    public void OnPurchase()
    {
        //Check to See if the Player can Afford the Purchase
        if (GM.plaguePoints >= cost)
        {
            //Subtract the Cost from the Plague Points
            GM.plaguePoints -= cost;

            //Add to the Score
            GM.score += 1;

            //Increase the Strain's Level
            level += 1;

            //Increase the IPSAdd Value by the InfectMod
            IPSAdd += infectMod;

            //Increase the Cost by Multiplying it by the CostMod and Rounding to the Nearest Whole Number
            cost = Mathf.Round(cost * costMod);
        }
    }

    //This Function Increases the Time Value
    private void timeAdd()
    {
        time += 1;
    }

    //The Function that Triggers the timeAdd() Function
    IEnumerator AutoTick()
    {
        //While the CoRoutine is Active
        while (true)
        {
            timeAdd();
            yield return new WaitForSeconds(1);
        }
    }
}

