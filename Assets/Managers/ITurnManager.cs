using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITurnManager
{
    public int GetAge();
    public int GetTurn();
    public void NextTurn();
    public void DrawNextEncounter();
    

}
