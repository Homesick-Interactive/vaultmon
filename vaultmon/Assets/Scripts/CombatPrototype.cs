using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, CHOICE, RESOLVE, END }

public class CombatPrototype : MonoBehaviour
{
    public BattleState state;

    void loadBattleHud();

    void spriteEnter();

    void actionChoice();

    void resolveTurn();

    void autoResolveTurn();

    void endBattle();

    void Start()
    {
        state = BattleState.START;

        loadBattleHud();
        //load character sprites, fade in slide in

    }

    void loadBattleHud() //loads battle UI and background, then calls spriteEnter()
    {

    }
}
