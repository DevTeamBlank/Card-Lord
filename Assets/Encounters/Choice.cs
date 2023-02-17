using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Choice : MonoBehaviour, IChoice
{
    [ArrayElementTitle("chipType")]
    [SerializeField] protected readonly int[] requireChips_ = new int[7];

    public int[] GetRequireChips() {
        return requireChips_;
    }

    [SerializeField] protected readonly string text_;
    public string GetText() {
        return text_;
    }

    public virtual void ChooseChoice() {
        // 상속 받은 Choice가 Overriding으로 구현
        throw new System.NotImplementedException();
    }

    public bool IsChoosable() {
        int[] numberOfPlayedChips = ChipManager.Inst.GetPlayedChips();
        return Judge(numberOfPlayedChips);
    }

    bool Judge(int[] numberOfPlayerChips) { // Replacibility에 따라 수정해야함
        for (int i = 0; i < requireChips_.Length; i++) {
            if (numberOfPlayerChips[i] != requireChips_[i]) {
                return false;
            }
        }
        return true;
    }

    private void Update() {
        // if (clicked)
        //     Choose();
    }

    void Choose() {
        InputManager.Inst.ClickedChoice(gameObject);
    }
}
