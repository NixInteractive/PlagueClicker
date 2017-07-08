using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour {

    //References for Save Data
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

    // Use this for initialization
    void Start () {

        if (PlayerPrefs.GetInt("Saved") >= 1)
        {
            //Game Manager Load
            GM.infections = PlayerPrefs.GetFloat("Infections");
            GM.ips = PlayerPrefs.GetFloat("InfectionsPerSec");
            GM.ipc = PlayerPrefs.GetFloat("InfectionsPerClick");
            GM.plaguePoints = PlayerPrefs.GetFloat("PlaguePoints");
            GM.ppps = PlayerPrefs.GetFloat("PPPerSec");
            GM.pppc = PlayerPrefs.GetFloat("PPPerClick");
            GM.cure = PlayerPrefs.GetFloat("Cure");
            GM.days = PlayerPrefs.GetInt("Days");
            GM.score = PlayerPrefs.GetInt("Score");

            //Bacteria Load
            Bac.cost = PlayerPrefs.GetFloat("BacCost");
            Bac.IPSAdd = PlayerPrefs.GetFloat("BacIPSAdd");
            Bac.maxTime = PlayerPrefs.GetFloat("BacMaxTime");
            Bac.costMod = PlayerPrefs.GetFloat("BacCostMod");
            Bac.infectMod = PlayerPrefs.GetFloat("BacInfectMod");
            Bac.level = PlayerPrefs.GetInt("BacLevel");
            Bac.time = PlayerPrefs.GetInt("BacTime");

            //Virus Load
            Vir.cost = PlayerPrefs.GetFloat("VirCost");
            Vir.IPSAdd = PlayerPrefs.GetFloat("VirIPSAdd");
            Vir.maxTime = PlayerPrefs.GetFloat("VirMaxTime");
            Vir.costMod = PlayerPrefs.GetFloat("VirCostMod");
            Vir.infectMod = PlayerPrefs.GetFloat("VirInfectMod");
            Vir.level = PlayerPrefs.GetInt("VirLevel");
            Vir.time = PlayerPrefs.GetInt("VirTime");

            //Fungus Load
            Fun.cost = PlayerPrefs.GetFloat("FunCost");
            Fun.IPSAdd = PlayerPrefs.GetFloat("FunIPSAdd");
            Fun.maxTime = PlayerPrefs.GetFloat("FunMaxTime");
            Fun.costMod = PlayerPrefs.GetFloat("FunCostMod");
            Fun.infectMod = PlayerPrefs.GetFloat("FunInfectMod");
            Fun.level = PlayerPrefs.GetInt("FunLevel");
            Fun.time = PlayerPrefs.GetInt("FunTime");

            //Prion Load
            Pri.cost = PlayerPrefs.GetFloat("PriCost");
            Pri.IPSAdd = PlayerPrefs.GetFloat("PriIPSAdd");
            Pri.maxTime = PlayerPrefs.GetFloat("PriMaxTime");
            Pri.costMod = PlayerPrefs.GetFloat("PriCostMod");
            Pri.infectMod = PlayerPrefs.GetFloat("PriInfectMod");
            Pri.level = PlayerPrefs.GetInt("PriLevel");
            Pri.time = PlayerPrefs.GetInt("PriTime");

            //Algae Load
            Alg.cost = PlayerPrefs.GetFloat("AlgCost");
            Alg.IPSAdd = PlayerPrefs.GetFloat("AlgIPSAdd");
            Alg.maxTime = PlayerPrefs.GetFloat("AlgMaxTime");
            Alg.costMod = PlayerPrefs.GetFloat("AlgCostMod");
            Alg.infectMod = PlayerPrefs.GetFloat("AlgInfectMod");
            Alg.level = PlayerPrefs.GetInt("AlgLevel");
            Alg.time = PlayerPrefs.GetInt("AlgTime");

            //Endoparasite Load
            End.cost = PlayerPrefs.GetFloat("EndCost");
            End.IPSAdd = PlayerPrefs.GetFloat("EndIPSAdd");
            End.maxTime = PlayerPrefs.GetFloat("EndMaxTime");
            End.costMod = PlayerPrefs.GetFloat("EndCostMod");
            End.infectMod = PlayerPrefs.GetFloat("EndInfectMod");
            End.level = PlayerPrefs.GetInt("EndLevel");
            End.time = PlayerPrefs.GetInt("EndTime");

            //Ectoparasite Load
            Ect.cost = PlayerPrefs.GetFloat("EctCost");
            Ect.IPSAdd = PlayerPrefs.GetFloat("EctIPSAdd");
            Ect.maxTime = PlayerPrefs.GetFloat("EctMaxTime");
            Ect.costMod = PlayerPrefs.GetFloat("EctCostMod");
            Ect.infectMod = PlayerPrefs.GetFloat("EctInfectMod");
            Ect.level = PlayerPrefs.GetInt("EctLevel");
            Ect.time = PlayerPrefs.GetInt("EctTime");

            //Nanovirus Load
            Nan.cost = PlayerPrefs.GetFloat("NanCost");
            Nan.IPSAdd = PlayerPrefs.GetFloat("NanIPSAdd");
            Nan.maxTime = PlayerPrefs.GetFloat("NanMaxTime");
            Nan.costMod = PlayerPrefs.GetFloat("NanCostMod");
            Nan.infectMod = PlayerPrefs.GetFloat("NanInfectMod");
            Nan.level = PlayerPrefs.GetInt("NanLevel");
            Nan.time = PlayerPrefs.GetInt("NanTime");

            //Synthovirus Load
            Syn.cost = PlayerPrefs.GetFloat("SynCost");
            Syn.IPSAdd = PlayerPrefs.GetFloat("SynIPSAdd");
            Syn.maxTime = PlayerPrefs.GetFloat("SynMaxTime");
            Syn.costMod = PlayerPrefs.GetFloat("SynCostMod");
            Syn.infectMod = PlayerPrefs.GetFloat("SynInfectMod");
            Syn.level = PlayerPrefs.GetInt("SynLevel");
            Syn.time = PlayerPrefs.GetInt("SynTime");
        }
    }
	
	// Update is called once per frame
	void Update () {

        PlayerPrefs.SetInt("Saved", 1);

        //Game Manager Values
        PlayerPrefs.SetFloat("Infections", GM.infections);
        PlayerPrefs.SetFloat("InfectionsPerSec", GM.ips);
        PlayerPrefs.SetFloat("InfectionsPerClick", GM.ipc);
        PlayerPrefs.SetFloat("PlaguePoints", GM.plaguePoints);
        PlayerPrefs.SetFloat("PPPerSec", GM.ppps);
        PlayerPrefs.SetFloat("PPPerClick", GM.pppc);
        PlayerPrefs.SetFloat("Cure", GM.cure);
        PlayerPrefs.SetInt("Days", GM.days);
        PlayerPrefs.SetInt("Score", GM.score);

        //Bacteria Values
        PlayerPrefs.SetFloat("BacCost", Bac.cost);
        PlayerPrefs.SetFloat("BacIPSAdd", Bac.IPSAdd);
        PlayerPrefs.SetFloat("BacMaxTime", Bac.maxTime);
        PlayerPrefs.SetFloat("BacCostMod", Bac.costMod);
        PlayerPrefs.SetFloat("BacInfectMod", Bac.infectMod);
        PlayerPrefs.SetInt("BacLevel", Bac.level);
        PlayerPrefs.SetInt("BacTime", Bac.time);

        //Virus Values
        PlayerPrefs.SetFloat("VirCost", Vir.cost);
        PlayerPrefs.SetFloat("VirIPSAdd", Vir.IPSAdd);
        PlayerPrefs.SetFloat("VirMaxTime", Vir.maxTime);
        PlayerPrefs.SetFloat("VirCostMod", Vir.costMod);
        PlayerPrefs.SetFloat("VirInfectMod", Vir.infectMod);
        PlayerPrefs.SetInt("VirLevel", Vir.level);
        PlayerPrefs.SetInt("VirTime", Vir.time);

        //Fungus Values
        PlayerPrefs.SetFloat("FunCost", Fun.cost);
        PlayerPrefs.SetFloat("FunIPSAdd", Fun.IPSAdd);
        PlayerPrefs.SetFloat("FunMaxTime", Fun.maxTime);
        PlayerPrefs.SetFloat("FunCostMod", Fun.costMod);
        PlayerPrefs.SetFloat("FunInfectMod", Fun.infectMod);
        PlayerPrefs.SetInt("FunLevel", Fun.level);
        PlayerPrefs.SetInt("FunTime", Fun.time);

        //Prion Values
        PlayerPrefs.SetFloat("PriCost", Pri.cost);
        PlayerPrefs.SetFloat("PriIPSAdd", Pri.IPSAdd);
        PlayerPrefs.SetFloat("PriMaxTime", Pri.maxTime);
        PlayerPrefs.SetFloat("PriCostMod", Pri.costMod);
        PlayerPrefs.SetFloat("PriInfectMod", Pri.infectMod);
        PlayerPrefs.SetInt("PriLevel", Pri.level);
        PlayerPrefs.SetInt("PriTime", Pri.time);

        //Algae Values
        PlayerPrefs.SetFloat("AlgCost", Alg.cost);
        PlayerPrefs.SetFloat("AlgIPSAdd", Alg.IPSAdd);
        PlayerPrefs.SetFloat("AlgMaxTime", Alg.maxTime);
        PlayerPrefs.SetFloat("AlgCostMod", Alg.costMod);
        PlayerPrefs.SetFloat("AlgInfectMod", Alg.infectMod);
        PlayerPrefs.SetInt("AlgLevel", Alg.level);
        PlayerPrefs.SetInt("AlgTime", Alg.time);

        //Ectoparasite Values
        PlayerPrefs.SetFloat("EctCost", Ect.cost);
        PlayerPrefs.SetFloat("EctIPSAdd", Ect.IPSAdd);
        PlayerPrefs.SetFloat("EctMaxTime", Ect.maxTime);
        PlayerPrefs.SetFloat("EctCostMod", Ect.costMod);
        PlayerPrefs.SetFloat("EctInfectMod", Ect.infectMod);
        PlayerPrefs.SetInt("EctLevel", Ect.level);
        PlayerPrefs.SetInt("EctTime", Ect.time);

        //Endoparasite Values
        PlayerPrefs.SetFloat("EndCost", End.cost);
        PlayerPrefs.SetFloat("EndIPSAdd", End.IPSAdd);
        PlayerPrefs.SetFloat("EndMaxTime", End.maxTime);
        PlayerPrefs.SetFloat("EndCostMod", End.costMod);
        PlayerPrefs.SetFloat("EndInfectMod", End.infectMod);
        PlayerPrefs.SetInt("EndLevel", End.level);
        PlayerPrefs.SetInt("EndTime", End.time);

        //Nanovirus Values
        PlayerPrefs.SetFloat("NanCost", Nan.cost);
        PlayerPrefs.SetFloat("NanIPSAdd", Nan.IPSAdd);
        PlayerPrefs.SetFloat("NanMaxTime", Nan.maxTime);
        PlayerPrefs.SetFloat("NanCostMod", Nan.costMod);
        PlayerPrefs.SetFloat("NanInfectMod", Nan.infectMod);
        PlayerPrefs.SetInt("NanLevel", Nan.level);
        PlayerPrefs.SetInt("NanTime", Nan.time);

        //Synthovirus Values
        PlayerPrefs.SetFloat("SynCost", Syn.cost);
        PlayerPrefs.SetFloat("SynIPSAdd", Syn.IPSAdd);
        PlayerPrefs.SetFloat("SynMaxTime", Syn.maxTime);
        PlayerPrefs.SetFloat("SynCostMod", Syn.costMod);
        PlayerPrefs.SetFloat("SynInfectMod", Syn.infectMod);
        PlayerPrefs.SetInt("SynLevel", Syn.level);
        PlayerPrefs.SetInt("SynTime", Syn.time);
    }
}
