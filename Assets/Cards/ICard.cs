using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard {

    void GetCardType(GameObject card);
    void Played(int choice);
    bool IsUsableAs(CardType anotherType); // check through HandManager


}

public enum CardType {
    gold,
    food,
    resource,
    civil,
    military,
    karma,
    heritage
}
