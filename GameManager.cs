using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //Strains References
    public StrainsManager Bac;
    public StrainsManager Vir;
    public StrainsManager Fun;
    public StrainsManager Pri;
    public StrainsManager Alg;
    public StrainsManager End;
    public StrainsManager Ect;
    public StrainsManager Nan;
    public StrainsManager Syn;

    //UI Text Elements
    public Text infectDisp;
    public Text ipsDisp;
    public Text ipcDisp;
    public Text plagueDisp;
    public Text pppsDisp;
    public Text pppcDisp;
    public Text stage;
    public Text date;

    //Infections Floats
    public float infections = 0;
    public float ips = 0;
    public float ipc = 1;

    //Plague Points Floats
    public float plaguePoints = 0;
    public float ppps = 0;
    public float pppc = 0;

    //Cure Value
    public float cure;

    //Name of the Current Stage(Not Used in Current Build)
    public string stageName;

    //Time Related Ints
    public int hours = 0;
    public int days = 0;

    //Score Value for Submission
    public int score = 0;

    // Use this for initialization
    void Start () {

        //Starts the Time Function
        StartCoroutine(time());
		
	}
	
	// Update is called once per frame
	void Update () {

        //Submit Score
        Application.ExternalCall("kongregate.stats.submit", "Score", score);

        //Incremental Numbers
        ipc = Mathf.Round(infections * 0.005f);
        pppc = Mathf.Round(ipc * 0.3f);
        ips = Mathf.Round(ppps * .13f);
        ppps = Mathf.Round(days * .15f);

        //Infect #'s
        if (infections >= Mathf.Pow(10, 3))
        {
            if (infections >= Mathf.Pow(10, 6))
            {
                if (infections >= Mathf.Pow(10, 9))
                {
                    if (infections >= Mathf.Pow(10, 12))
                    {
                        if (infections >= Mathf.Pow(10, 15))
                        {
                            if (infections >= Mathf.Pow(10, 18))
                            {
                                if (infections >= Mathf.Pow(10, 21))
                                {
                                    if (infections >= Mathf.Pow(10, 24))
                                    {
                                        if (infections >= Mathf.Pow(10, 27))
                                        {
                                            if (infections >= Mathf.Pow(10, 30))
                                            {
                                                infectDisp.text = "Infections: " + (infections * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                infectDisp.text = "Infections: " + (infections * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }else
                                        {
                                            infectDisp.text = "Infections: " + (infections * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        infectDisp.text = "Infections: " + (infections * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }else
                                {
                                    infectDisp.text = "Infections: " + (infections * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                infectDisp.text = "Infections: " + (infections * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        } else
                        {
                            infectDisp.text = "Infections: " + (infections * 0.000000000001).ToString("#.00") + "T";
                        }
                    } else
                    {
                        infectDisp.text = "Infections: " + (infections * 0.000000001).ToString("#.00") + "B";
                    }
                } else
                {
                    infectDisp.text = "Infections: " + (infections * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                infectDisp.text = "Infections: " + (infections * 0.001f).ToString("#.00") + "K";
            }
        }else
        {
            infectDisp.text = "Infections: " + infections;
        }

        //IPS #'s
        if (ips >= Mathf.Pow(10, 3))
        {
            if (ips >= Mathf.Pow(10, 6))
            {
                if (ips >= Mathf.Pow(10, 9))
                {
                    if (ips >= Mathf.Pow(10, 12))
                    {
                        if (ips >= Mathf.Pow(10, 15))
                        {
                            if (ips >= Mathf.Pow(10, 18))
                            {
                                if (ips >= Mathf.Pow(10, 21))
                                {
                                    if (ips >= Mathf.Pow(10, 24))
                                    {
                                        if (ips >= Mathf.Pow(10, 27))
                                        {
                                            if (ips >= Mathf.Pow(10, 30))
                                            {
                                                ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }
                                        else
                                        {
                                            ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }
                                else
                                {
                                    ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        }
                        else
                        {
                            ipsDisp.text = "Bonus IPS: " + (ips * 0.000000000001).ToString("#.00") + "T";
                        }
                    }
                    else
                    {
                        ipsDisp.text = "Bonus IPS: " + (ips * 0.000000001).ToString("#.00") + "B";
                    }
                }
                else
                {
                    ipsDisp.text = "Bonus IPS: " + (ips * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                ipsDisp.text = "Bonus IPS: " + (ips * 0.001f).ToString("#.00") + "K";
            }
        }
        else
        {
            ipsDisp.text = "Bonus IPS: " + ips;
        }

        //IPC #'s
        if (ipc >= Mathf.Pow(10, 3))
        {
            if (ipc >= Mathf.Pow(10, 6))
            {
                if (ipc >= Mathf.Pow(10, 9))
                {
                    if (ipc >= Mathf.Pow(10, 12))
                    {
                        if (ipc >= Mathf.Pow(10, 15))
                        {
                            if (ipc >= Mathf.Pow(10, 18))
                            {
                                if (ipc >= Mathf.Pow(10, 21))
                                {
                                    if (ipc >= Mathf.Pow(10, 24))
                                    {
                                        if (ipc >= Mathf.Pow(10, 27))
                                        {
                                            if (ipc >= Mathf.Pow(10, 30))
                                            {
                                                ipcDisp.text = "IPC: " + (ipc * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                ipcDisp.text = "IPC: " + (ipc * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }
                                        else
                                        {
                                            ipcDisp.text = "IPC: " + (ipc * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        ipcDisp.text = "IPC: " + (ipc * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }
                                else
                                {
                                    ipcDisp.text = "IPC: " + (ipc * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                ipcDisp.text = "IPC: " + (ipc * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        }
                        else
                        {
                            ipcDisp.text = "IPC: " + (ipc * 0.000000000001).ToString("#.00") + "T";
                        }
                    }
                    else
                    {
                        ipcDisp.text = "IPC: " + (ipc * 0.000000001).ToString("#.00") + "B";
                    }
                }
                else
                {
                    ipcDisp.text = "IPC: " + (ipc * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                ipcDisp.text = "IPC: " + (ipc * 0.001f).ToString("#.00") + "K";
            }
        }
        else
        {
            ipcDisp.text = "IPC: " + ipc;
        }

        //Plague Points #'s
        if (plaguePoints >= Mathf.Pow(10, 3))
        {
            if (plaguePoints >= Mathf.Pow(10, 6))
            {
                if (plaguePoints >= Mathf.Pow(10, 9))
                {
                    if (plaguePoints >= Mathf.Pow(10, 12))
                    {
                        if (plaguePoints >= Mathf.Pow(10, 15))
                        {
                            if (plaguePoints >= Mathf.Pow(10, 18))
                            {
                                if (plaguePoints >= Mathf.Pow(10, 21))
                                {
                                    if (plaguePoints >= Mathf.Pow(10, 24))
                                    {
                                        if (plaguePoints >= Mathf.Pow(10, 27))
                                        {
                                            if (plaguePoints >= Mathf.Pow(10, 30))
                                            {
                                                plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }
                                        else
                                        {
                                            plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }
                                else
                                {
                                    plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        }
                        else
                        {
                            plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000000001).ToString("#.00") + "T";
                        }
                    }
                    else
                    {
                        plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000000001).ToString("#.00") + "B";
                    }
                }
                else
                {
                    plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                plagueDisp.text = "Plague Pts: " + (plaguePoints * 0.001f).ToString("#.00") + "K";
            }
        }
        else
        {
            plagueDisp.text = "Plague Pts: " + plaguePoints;
        }

        //PPPS #'s
        if (ppps >= Mathf.Pow(10, 3))
        {
            if (ppps >= Mathf.Pow(10, 6))
            {
                if (ppps >= Mathf.Pow(10, 9))
                {
                    if (ppps >= Mathf.Pow(10, 12))
                    {
                        if (ppps >= Mathf.Pow(10, 15))
                        {
                            if (ppps >= Mathf.Pow(10, 18))
                            {
                                if (ppps >= Mathf.Pow(10, 21))
                                {
                                    if (ppps >= Mathf.Pow(10, 24))
                                    {
                                        if (ppps >= Mathf.Pow(10, 27))
                                        {
                                            if (ppps >= Mathf.Pow(10, 30))
                                            {
                                                pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }
                                        else
                                        {
                                            pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }
                                else
                                {
                                    pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        }
                        else
                        {
                            pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000000001).ToString("#.00") + "T";
                        }
                    }
                    else
                    {
                        pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000000001).ToString("#.00") + "B";
                    }
                }
                else
                {
                    pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                pppsDisp.text = "P.P. Per Sec: " + (ppps * 0.001f).ToString("#.00") + "K";
            }
        }
        else
        {
            pppsDisp.text = "P.P. Per Sec: " + ppps;
        }

        //PPPC #'s
        if (pppc >= Mathf.Pow(10, 3))
        {
            if (pppc >= Mathf.Pow(10, 6))
            {
                if (pppc >= Mathf.Pow(10, 9))
                {
                    if (pppc >= Mathf.Pow(10, 12))
                    {
                        if (pppc >= Mathf.Pow(10, 15))
                        {
                            if (pppc >= Mathf.Pow(10, 18))
                            {
                                if (pppc >= Mathf.Pow(10, 21))
                                {
                                    if (pppc >= Mathf.Pow(10, 24))
                                    {
                                        if (pppc >= Mathf.Pow(10, 27))
                                        {
                                            if (pppc >= Mathf.Pow(10, 30))
                                            {
                                                pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }
                                        else
                                        {
                                            pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }
                                else
                                {
                                    pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        }
                        else
                        {
                            pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000000001).ToString("#.00") + "T";
                        }
                    }
                    else
                    {
                        pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000000001).ToString("#.00") + "B";
                    }
                }
                else
                {
                    pppcDisp.text = "P.P. Per Click: " + (pppc * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                pppcDisp.text = "P.P. Per Click: " + (pppc * 0.001f).ToString("#.00") + "K";
            }
        }
        else
        {
            pppcDisp.text = "P.P. Per Click: " + pppc;
        }

        //Days #'s
        if (days >= Mathf.Pow(10, 3))
        {
            if (days >= Mathf.Pow(10, 6))
            {
                if (days >= Mathf.Pow(10, 9))
                {
                    if (days >= Mathf.Pow(10, 12))
                    {
                        if (days >= Mathf.Pow(10, 15))
                        {
                            if (days >= Mathf.Pow(10, 18))
                            {
                                if (days >= Mathf.Pow(10, 21))
                                {
                                    if (days >= Mathf.Pow(10, 24))
                                    {
                                        if (days >= Mathf.Pow(10, 27))
                                        {
                                            if (days >= Mathf.Pow(10, 30))
                                            {
                                                date.text = "Day: " + (days * 0.000000000000000000000000000001).ToString("#.00") + "N";
                                            }
                                            else
                                            {
                                                date.text = "Day: " + (days * 0.000000000000000000000000001).ToString("#.00") + "O";
                                            }
                                        }
                                        else
                                        {
                                            date.text = "Day: " + (days * 0.000000000000000000000001).ToString("#.00") + "Sp";
                                        }
                                    }
                                    else
                                    {
                                        date.text = "Day: " + (days * 0.000000000000000000001).ToString("#.00") + "Sx";
                                    }
                                }
                                else
                                {
                                    date.text = "Day: " + (days * 0.000000000000000001).ToString("#.00") + "Qi";
                                }
                            }
                            else
                            {
                                date.text = "Day: " + (days * 0.000000000000001).ToString("#.00") + "Qa";
                            }
                        }
                        else
                        {
                            date.text = "Day: " + (days * 0.000000000001).ToString("#.00") + "T";
                        }
                    }
                    else
                    {
                        date.text = "Day: " + (days * 0.000000001).ToString("#.00") + "B";
                    }
                }
                else
                {
                    date.text = "Day: " + (days * 0.000001f).ToString("#.00") + "M";
                }
            }
            else
            {
                date.text = "Day: " + (days * 0.001f).ToString("#.00") + "K";
            }
        }
        else
        {
            date.text = "Day: " + days;
        }

        //Making Sure the IPC is Never Less Than 1
        if (ipc <= 1)
        {
            ipc = 1;
            ipcDisp.text = "IPC: 1";
        }

}

    //Per Second Function
    private void timeAdd()
    {
        hours += 1;
        cure += 1;
        infections += ips;
        plaguePoints += ppps;

        //Hours Reset
        if(hours >= 24)
        {
            days += 1;
            hours = 0;

            //Submit Days
            Application.ExternalCall("kongregate.stats.submit", "Days", days);
        }
    }

    //Per Second Trigger
    IEnumerator time()
    {
        //While the CoRoutine is active
        while (true)
        {
            timeAdd();
            yield return new WaitForSeconds(1);
        }
    }

}
