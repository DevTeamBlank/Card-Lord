using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    [SerializeField] GameObject[] policy = new GameObject[4];
    [SerializeField] GameObject[] building = new GameObject[4];
    [SerializeField] GameObject[] artist = new GameObject[4];
    [SerializeField] GameObject[] eureka = new GameObject[4];
    [SerializeField] GameObject[] expedition = new GameObject[4];

    [SerializeField]
    int[] fixedTurn = new int[5];

    IEncounter currentEncounter;

    public void Notify(int number) {

    }

    public IEncounter GetCurrentEncounter() {
        return currentEncounter;
    }

    public void DrawNextEncounter() {
        if (!CheckFixedEncounter()) {
            AgeType age = TurnManager.Inst.GetAge();

            // TODO
            GameObject encounter = age3Encounters_[0];

            UpdateCurrentEncounter(encounter);
        }
        throw new System.NotImplementedException();
    }

    void UpdateCurrentEncounter(GameObject encounter) {
        currentEncounter = encounter.GetComponent<Encounter>();
        currentEncounter.Encountered();
        currentEncounter.Display();
    }

    bool CheckFixedEncounter() {
        int age = (int) GameManager.Inst.GetAge().ageType;
        int turn = GameManager.Inst.GetTurn();
        if (turn == fixedTurn[0]) {
            UpdateCurrentEncounter(policy[age]);
            return true;           
        } else if (turn == fixedTurn[1]) {
            UpdateCurrentEncounter(building[age]);
            return true;
        } else if (turn == fixedTurn[2]) {
            UpdateCurrentEncounter(artist[age]);
            return true;
        } else if (turn == fixedTurn[3]) {
            UpdateCurrentEncounter(eureka[age]);
            return true;
        } else if (turn == fixedTurn[4]) {
            UpdateCurrentEncounter(expedition[age]);
            return true;
        }
        return false;
    }

    IEncounter IEncounterManager.GetCurrentEncounter() {
        return currentEncounter;
    }

    public void FixEncounter() {
        fixedTurn[0] = 0; // policy
        for (int i = 0; i < 4; i++) { // building, artist, eureka, expedition
            int random = GameManager.Inst.GetRandom(i, 8);
            fixedTurn[i + 1] = 4 + 8 * i + random;
        }
    }
}
