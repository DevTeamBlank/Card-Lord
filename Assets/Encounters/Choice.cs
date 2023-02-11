using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour, IChoice {

    readonly int number;
    readonly List<Card> requireList;
    readonly List<Card>[] awardList; // may affected by random

    private void Update() {
        if (true) { // when clicked
            // Call InputManager
        }
    }



    public Choice(int number) {
        this.number = number;
    }





    public int GetNumber() {
        return number;
    }
    public List<Card> GetRequireList() {
        return requireList;
    }
    public List<Card>[] GetAwardList() {
        return awardList;
    }

    public bool IsChoosable() {
        // TODO
        return false;
    }


    public void Affect() { // when this choice is choosen
        GetAward();
        // TurnManager.Inst.
        // TurnManager(); ¿¡°Ô ³Ñ±è
    }

    private void GetAward() {
        // TODO
        // HandManager.Inst. 
    }
}
