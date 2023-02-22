using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounter {

    int GetPossibility();

    void Encountered();
    void UpdateEncountablity(int[] numberOfCurrentChips);

    void UpdateChoosability();
}
