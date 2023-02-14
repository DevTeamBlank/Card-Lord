using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour, ICard
{
    protected CardType cardType;

    public CardType GetCardType() {
        return cardType;
    }

    public void UpdateSprite() {
        // TODO
        throw new System.NotImplementedException();
    }
}
