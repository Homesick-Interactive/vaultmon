using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{

    public string unitName;
    public bool isFriend;
    public string[] moveList;
    public int unitHealthMax;
    public int unitHealth;
    public int unitPower;

    public Fighter(string unitName, string[] moveList, int unitHealthMax, int unitHealth, int unitPower)
    {
        if (unitName == null || unitName == "")
        {
            this.unitName = "MISSINGNO";
        }
        else
        {
            this.unitName = unitName;
        }

        switch (moveList.Length)
        {
            case 0:
                this.moveList = new string[]{"cry"};
                break;
            case 1:
            case 2:
            case 3:
            case 4: 
                this.moveList = moveList;
                break;
            default:
                this.moveList = new string[] { "cry", "cry", "cry", "cry" };
                break;
        }

        if (unitHealthMax > 0)
        {
            this.unitHealth = unitHealthMax;
        }
        else
        {
            this.unitHealth = 10;
        }

        if (unitHealth >= 0)
        {
            this.unitHealth = unitHealth;
        }
        else
        {
            this.unitHealth = unitHealthMax;
        }

        if (unitPower > 0)
        {
            this.unitPower = unitPower;
        }
        else
        {
            this.unitPower = 1;
        }
    }
}
