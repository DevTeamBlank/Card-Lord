using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterManager : MonoBehaviour, IEncounterManager {

    /* EncounterManager�� ���� ��ī���Ϳ� ������ ���� ��ī���͵��� �����մϴ�.
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
        // currentEncounter. ȣ��
    }

    public Encounter GetCurrentEncounter() {
        return currentEncounter;
    }
}
