using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterManager : MonoBehaviour, IEncounterManager {

    /* EncounterManager는 현재 인카운터와 다음에 뽑힐 인카운터들을 관리합니다.
     * 
     * 
     * 
     * 
     */

    public static IEncounterManager Inst;

    private void Awake() {
        Inst = this;
    }

    Encounter currentEncounter;

    public void Notify(int number) {

    }
    
    public void Display() {
        // currentEncounter. 호출
    }

    public Encounter GetCurrentEncounter() {
        return currentEncounter;
    }
}
