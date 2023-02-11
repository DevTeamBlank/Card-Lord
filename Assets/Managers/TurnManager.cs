using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour, ITurnManager
{
    public static ITurnManager Inst;

    private void Awake() {
        Inst = this;
    }



}
