using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, CHOICE, RESOLVE, END }

public class CombatPrototype : MonoBehaviour
{
    public BattleState state;

    void Start()
    {
        state = BattleState.START;

        LoadBattleHud();
        //load character sprites, fade in slide in

    }

    void LoadBattleHud() //loads battle UI and background, then calls spriteEnter()
    {
        SpriteEnter();
    }

    void SpriteEnter() // put sprites on the field
    {

    }

    void ActionChoice() // fighters choose their next action
    {

    }

    void ResolveTurn() // actions take place
    {

    }

    void AutoResolveTurn() // for sneak attack
    {

    }

    void EndBattle() // experience and loot at the end
    {

    }

    int DealDamage(int attackDamage, int fighterPower, int targetDefense, float[] damageModifiers)
    {
        float floatDamage = 0;
        float finalMultiplier = 1;
        floatDamage = attackDamage * (fighterPower - targetDefense);

        //adds each multiplier in damageModifiers to finalMultiplier
        for(int i = 0; i < damageModifiers.Length; i++)
        {
            finalMultiplier = finalMultiplier + damageModifiers[i];
        }

        //bounds finalMultiplier between 0 and 10
        if(finalMultiplier > 0)
        {
            finalMultiplier = 0;
        }
        else if(finalMultiplier > 10)
        {
            finalMultiplier = 10;
        }

        //multiplies floatDamage by combined damageMultipliers
        floatDamage = floatDamage * finalMultiplier;

        int output = Mathf.FloorToInt(floatDamage);
        return output;
    }

}
