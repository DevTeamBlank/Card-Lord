using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public GameObject[][] encounters_;

    [SerializeField] Vector3 encounterPosition_;

    [SerializeField] GameObject[] policy = new GameObject[4];
    [SerializeField] GameObject[] building = new GameObject[4];
    [SerializeField] GameObject[] artist = new GameObject[4];
    [SerializeField] GameObject[] eureka = new GameObject[4];
    [SerializeField] GameObject[] expedition = new GameObject[4];

    [SerializeField] int[] fixedTurn = new int[5];

    GameObject currentEncounter;    

    public IEncounter GetCurrentEncounter() {
        return currentEncounter.GetComponent<IEncounter>();
    }

    public void DrawNextEncounter() {
        if (!CheckFixedEncounter()) {
            int age = (int) TurnManager.Inst.GetAge().ageType;

            int[] sum = new int[encounters_[age].Length]; // 누적 합
            sum[0] = encounters_[age][0].GetComponent<IEncounter>().GetPossibility();
            for (int i = 1; i < sum.Length; i++) {
                sum[i] = sum[i - 1] + encounters_[age][i - 1].GetComponent<IEncounter>().GetPossibility();
            }
            int random = GameManager.Inst.GetRandom(0, sum[sum.Length - 1]);
            int index = System.Array.BinarySearch(sum, random);

            UpdateCurrentEncounter(encounters_[age][index]);
        }
        throw new System.NotImplementedException();
    }

    void UpdateCurrentEncounter(GameObject encounter) {
        currentEncounter.transform.position = new Vector3(100, 100, 100);
        currentEncounter = encounter;
        currentEncounter.GetComponent<IEncounter>().Encountered();
        encounter.transform.position = encounterPosition_;
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

    public void FixEncounter() {
        fixedTurn[0] = 0; // policy
        for (int i = 0; i < 4; i++) { // building, artist, eureka, expedition
            int random = GameManager.Inst.GetRandom(i, 8);
            fixedTurn[i + 1] = 4 + 8 * i + random;
        }
    }

    public void UpdateCurrentChips(int[] numberOfChips) {
        foreach(GameObject encounter in encounters_[(int)GameManager.Inst.GetAge().ageType]) {
            encounter.GetComponent<IEncounter>().UpdateEncountablity(numberOfChips);
        }
    }

    public void UpdateChoice() {
        currentEncounter.GetComponent<IEncounter>().UpdateChoosability();
    }
}
