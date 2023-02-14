using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard {

    CardType GetCardType();

    void UpdateSprite();

}

[System.Serializable]
public struct CardType {
    public enum CardName {
        gold, 
        food,
        resource,
        civil,
        military,
        karma,
        heritage
    }

    [SerializeField]
    public CardName cardType;
}

