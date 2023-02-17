using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

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

    // Encounter가 등장하려면 Encountability[i] 가 true이어야한다.
    [SerializeField] GameObject[] age1Encounters_;
    [SerializeField] bool[] age1Encountablity;
    [SerializeField] GameObject[] age2Encounters_;
    [SerializeField] bool[] age2Encountablity;
    [SerializeField] GameObject[] age3Encounters_;
    [SerializeField] bool[] age3Encountablity;
    [SerializeField] GameObject[] age4Encounters_;
    [SerializeField] bool[] age4Encountablity;

    [SerializeField] GameObject[] artist;
    [SerializeField] GameObject[] eureka;
    [SerializeField] GameObject[] building;
    [SerializeField] GameObject[] expedition;
    [SerializeField] GameObject[] policy;

    IEncounter currentEncounter;

    public void Notify(int number) {

    }
    
    public IEncounter GetCurrentEncounter() {
        return currentEncounter;
    }

    public void DrawNextEncounter() {
        bool isFixed = CheckFixedEncounter();
        AgeType age = TurnManager.Inst.GetAge();

        // TODO
        GameObject encounter = age3Encounters_[0];

        UpdateCurrentEncounter(encounter);
        throw new System.NotImplementedException();
    }

    void UpdateCurrentEncounter(GameObject encounter) {
        currentEncounter = encounter.GetComponent<Encounter>();
        currentEncounter.Encountered();
        currentEncounter.Display();
    }

    bool CheckFixedEncounter() {
        int turn = TurnManager.Inst.GetTurn();
        return false;
    }

    Encounter IEncounterManager.GetCurrentEncounter() {
        throw new System.NotImplementedException();
    }
}
