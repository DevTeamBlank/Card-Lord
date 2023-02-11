using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHandManager {
    void UpdateCardSprite(); // when a new age is started

    void ReceiveCards(List<GameObject> cards);
    void DiscardCard(GameObject[] cards);
    void PlaceCard(GameObject card);

    void SetBuildingStatus(bool inProgress);
    void RequireCard(CardType cardType); // when a building is in progress

    bool ReplacableAs(CardType originType, CardType anotherType); 
    void UpdateReplacability(CardType originType, CardType anotherType, bool replacable); // buildings will update this 
}
