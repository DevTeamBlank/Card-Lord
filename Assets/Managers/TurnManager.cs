using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour, ITurnManager
{
    public static ITurnManager Inst;

    private void Awake() {
        Inst = this;
    }

    public readonly int maxTurn;

    [SerializeField] AgeType age;
    [SerializeField] int turn;

    public AgeType GetAge() {
        return age;
    }

    public int GetTurn() {
        return turn;
    }

    public void NextTurn() {
        turn++;
        if (maxTurn < turn) {
            // policy
        }
    }

    public void DrawNextEncounter() {
        // Call EncounterManager with info
        throw new System.NotImplementedException();
    }

}
