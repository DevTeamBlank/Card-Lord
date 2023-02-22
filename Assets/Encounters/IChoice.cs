using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChoice {
    int[] GetRequireChips();

    void UpdateChoosability(); // ChipManager에게 현재 playedChip을 받아옴
    void ChooseChoice();

}
