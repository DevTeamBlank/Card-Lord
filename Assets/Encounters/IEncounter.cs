using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounter {

    void Display(); // when this encounter is drawn from the pool

    void Encountered();
    void UpdateEncountablity(int[] numberOfCurrentChips);
    bool IsEncountable();
}
