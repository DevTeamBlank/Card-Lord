using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter : MonoBehaviour, IEncounter {

    public readonly int index_;
    public readonly string nomenclature_;
    public readonly string text_;

    public GameObject[] choices;

    public void Display() {

    }

    public void Encountered() {
        encountered = true;
    }

    [SerializeField] protected bool encountered = false;
    [SerializeField] protected bool isEncountable = true;

    public bool IsEncountable() {
        if (encountered) {
            return false;
        }
        return isEncountable;
    }

    public virtual void UpdateEncountablity(int[] numberOfCurrentChips) {
        // 상속받아서 구현할 것
        throw new System.NotImplementedException();
    }
}