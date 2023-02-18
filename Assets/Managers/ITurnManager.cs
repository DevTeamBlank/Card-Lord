using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITurnManager {

    public static readonly int MAX_TURN = 40;

    public AgeType GetAge();

    public void AgeStart();
    public void AgeEnd();

    public int GetTurn();
    public void TurnStart();

    public void TurnEnd();


}


[System.Serializable]
public struct AgeType {
    public enum AgeName {
        pregame,
        middle,
        modern,
        contemporary,
        future
    }

    [SerializeField]
    public AgeName ageType;
}
