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

}
