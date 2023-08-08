using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public int itemWealthCost;
    public string itemName, itemDesc;
    public Sprite itemSprite;
    public bool isEquipment;

    public Loot(int _itemWealthCost, string _itemName, string _itemDesc, Sprite _itemSprite, bool _isEquipment) 
    {
        this.itemWealthCost = _itemWealthCost;
        this.itemName = _itemName;
        this.itemDesc = _itemDesc;
        this.itemSprite = _itemSprite;
        this.isEquipment = _isEquipment;
    }
}
