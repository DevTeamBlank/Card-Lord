using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChoice {
    string GetText();
    int[] GetRequireChips();

    bool IsChoosable(); // ChipManager���� ���� playedChip�� �޾ƿ�
    void ChooseChoice();

}
