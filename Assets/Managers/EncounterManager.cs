using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterManager : MonoBehaviour, IEncounterManager {

    public static IEncounterManager Inst;

    private void Awake() {
        Inst = this;
    }

    private Encounter currentEncounter;

    public void Notify(int number) {

    }
    
    public void Display() {
        // currentEncounter. »£√‚
    }

}
