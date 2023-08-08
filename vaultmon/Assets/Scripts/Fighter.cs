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
    public int level;
    public int unitWealthCost;
    public Loot[] items;

    public Fighter(string _unitName, string[] _moveList, int _unitHealthMax, int _unitHealth, int _unitPower)
    {
        if (_unitName == null || _unitName == "")
        {
            this.unitName = "MISSINGNO";
        }
        else
        {
            this.unitName = _unitName;
        }

        switch (_moveList.Length)
        {
            case 0:
                this.moveList = new string[]{"cry"};
                break;
            case 1:
            case 2:
            case 3:
            case 4: 
                this.moveList = _moveList;
                break;
            default:
                this.moveList = new string[] { "cry", "cry", "cry", "cry" };
                break;
        }

        if (_unitHealthMax > 0)
        {
            this.unitHealth = _unitHealthMax;
        }
        else
        {
            this.unitHealth = 10;
        }

        if (_unitHealth >= 0)
        {
            this.unitHealth = _unitHealth;
        }
        else
        {
            this.unitHealth = _unitHealthMax;
        }

        if (_unitPower > 0)
        {
            this.unitPower = _unitPower;
        }
        else
        {
            this.unitPower = 1;
        }
    }

    public Fighter(string _unitName, string[] _moveList, int _unitHealthMax, int _unitHealth, int _unitPower, bool _isFriend)
    {

        this.isFriend = _isFriend;
        if (_unitName == null || _unitName == "")
        {
            this.unitName = "MISSINGNO";
        }
        else
        {
            this.unitName = _unitName;
        }

        switch (_moveList.Length)
        {
            case 0:
                this.moveList = new string[] { "cry" };
                break;
            case 1:
            case 2:
            case 3:
            case 4:
                this.moveList = _moveList;
                break;
            default:
                this.moveList = new string[] { "cry", "cry", "cry", "cry" };
                break;
        }

        if (_unitHealthMax > 0)
        {
            this.unitHealth = _unitHealthMax;
        }
        else
        {
            this.unitHealth = 10;
        }

        if (_unitHealth >= 0)
        {
            this.unitHealth = _unitHealth;
        }
        else
        {
            this.unitHealth = _unitHealthMax;
        }

        if (_unitPower > 0)
        {
            this.unitPower = _unitPower;
        }
        else
        {
            this.unitPower = 1;
        }
    }
}
