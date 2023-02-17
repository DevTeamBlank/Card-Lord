using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChoice {
    string GetText();
    int[] GetRequireChips();

    bool IsChoosable(); // ChipManager에게 현재 playedChip을 받아옴
    void ChooseChoice();

}
