using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICardManager {

    /* CardManager�� �������� ī���� ����, ��� ���� ����մϴ�.
     * Card GameObject�� Play �Ǿ��� �� Encounter�� �������� ���� ���������� Ȯ���մϴ�.
     * Card Type�� �ٸ� Type���� ���� �� �ִ��� üũ�մϴ�.
     * Age�� �ٲ���� �� ��� ī����� Sprite�� ������Ʈ�մϴ�. (TurnManager�� ȣ��)
     * Hand�� ī�带 �ְ� ������ �մϴ�.
     */

    void UpdateCardSprite(); // when a new age is started

    void ReceiveCards(CardType[] cards); // Make a clone of prefab and add to hand
    void DiscardCard(GameObject[] cards);
    void PlayCard(GameObject card);

    void SetBuildingStatus(bool inProgress);
    void RequireCard(CardType cardType); // when a building is in progress

    bool ReplacableAs(CardType originType, CardType anotherType); 
    void UpdateReplacability(CardType originType, CardType anotherType, bool replacable); // buildings may update this 
}
