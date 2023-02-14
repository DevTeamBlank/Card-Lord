using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter : MonoBehaviour, IEncounter {

    public readonly int index;
    public readonly string nomenclature;
    public readonly string text;

    [SerializeField] ChoiceStruct[] choiceStructs;
    Choice[] choices;

    private void Start() {
        choices = new Choice[choiceStructs.Length];
        for (int i = 0; i < choices.Length; i++) {

        }
    }


    private void Update() {
        if (true) { // when clicked
                    // calculate which choice has chosen
                    // Call InputManager
        }
    }


    public void Display() {

    }

    protected struct ChoiceStruct {
        int number;
        CardType[] requireList;
        CardType[][] awardList;
    }

    protected class Choice {
        readonly int number;
        readonly CardType[] requireList;
        readonly CardType[][] awardList; // may affected by random

        public Choice(int number, CardType[] requireList, CardType[][] awardList) {
            this.number = number;
        }


        public bool IsChoosable() {
            // Check EncounterManager
            // TODO
            return false;
        }


        public void Affect() { // when this choice is choosen
            GetAward();
            // TurnManager.Inst.
            // TurnManager(); ¿¡°Ô ³Ñ±è
        }

        private void GetAward() {
            int random = Random.Range(0, awardList.Length);
            CardType[] award = awardList[random];
            CardManager.Inst.ReceiveCards(award);
        }
    }
}


