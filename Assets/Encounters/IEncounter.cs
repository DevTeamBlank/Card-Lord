using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounter {
    int GetIndex();
    Choice[] GetChoices();

    void Display(); // when this encounter is drawn from the pool

}
