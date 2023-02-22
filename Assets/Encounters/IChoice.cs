using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChoice {
    int[] GetRequireChips();

    void UpdateChoosability(); // ChipManager���� ���� playedChip�� �޾ƿ�
    void ChooseChoice();

}
