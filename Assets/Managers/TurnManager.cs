using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour, ITurnManager {
    public static ITurnManager Inst;

    private void Awake() {
        Inst = this;
    }

    public readonly int maxTurn = ITurnManager.MAX_TURN;

    [SerializeField] AgeType age;
    [SerializeField] int turn;

    public AgeType GetAge() {
        return age;
    }

    public void AgeStart() {
        age.ageType++;
        throw new System.NotImplementedException();
    }
    public void AgeEnd() {
        throw new System.NotImplementedException();
    }

    public int GetTurn() {
        return turn;
    }

    public void TurnStart() {
        turn++;

    }
    public void TurnEnd() {
        throw new System.NotImplementedException();
    }

}
