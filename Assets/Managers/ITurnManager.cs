using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITurnManager {


    public AgeType GetAge();
    public int GetTurn();
    public void NextTurn();
    public void DrawNextEncounter();


}

[System.Serializable]
public struct AgeType {
    public enum AgeName {
        middle,
        modern,
        contemporary,
        future
    }

    [SerializeField]
    public AgeName ageType;
}
