using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour, IInputManager
{
    public static IInputManager Inst;

    private void Awake() {
        Inst = this;
    }

    public void ClickedChip(GameObject chip) {
        if (!GameManager.Inst.GetAllowInput()) {
            return;
        }

        IChip currentChip = chip.GetComponent<Chip>();
        if (currentChip.GetIsPlayed()) {
            currentChip.RetrieveChip();
        } else {
            currentChip.PlayChip();
        }
    }

    public void ClickedChoice(GameObject choice) {
        if (!GameManager.Inst.GetAllowInput()) {
            return;
        }

        IChoice currentChoice = choice.GetComponent<Choice>();
        currentChoice.ChooseChoice();
    }

}
