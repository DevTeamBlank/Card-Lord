using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChoice
{
    int GetNumber();
    List<Card> GetRequireList();
    List<Card>[] GetAwardList();

    bool IsChoosable(); // enough cards are on the current encounter
    void WithdrawCards(); // when a withdraw button is pushed
    void Affect(); // when this choice is choosen

}
