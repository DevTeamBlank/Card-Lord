using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour, ICardManager {

    /* CardManager�� �������� ī���� ����, ��� ���� ����մϴ�.
     * Card GameObject�� Play �Ǿ��� �� Encounter�� �������� ���� ���������� Ȯ���մϴ�.
     * Card Type�� �ٸ� Type���� ���� �� �ִ��� üũ�մϴ�.
     * Age�� �ٲ���� �� ��� ī����� Sprite�� ������Ʈ�մϴ�. (TurnManager�� ȣ��)
     * Hand�� ī�带 �ְ� ������ �մϴ�.
     */

    public static ICardManager Inst;

    private void Awake() {
        Inst = this;
    }
    
    [ArrayElementTitle("cardType")]
    public readonly GameObject[] cardPrefabs;
    
    
    GameObject CardTypeToGameObject(CardType.CardName cardName) { // return clone
        return Instantiate(cardPrefabs[(int) cardName]);
    }

    public void ReceiveCards(CardType[] cards) {
        for (int i = 0; i < cards.Length; i++) {
            Hand.Inst.ReceiveCard(CardTypeToGameObject(cards[i].cardType));
        }
    }

    public void UpdateCardSprite() {
        throw new System.NotImplementedException();
    }

    public void DiscardCard(GameObject[] cards) {
        throw new System.NotImplementedException();
    }

    public void PlayCard(GameObject card) {
        throw new System.NotImplementedException();
    }

    public void SetBuildingStatus(bool inProgress) {
        throw new System.NotImplementedException();
    }

    public void RequireCard(CardType cardType) {
        throw new System.NotImplementedException();
    }

    public bool ReplacableAs(CardType originType, CardType anotherType) {
        throw new System.NotImplementedException();
    }

    public void UpdateReplacability(CardType originType, CardType anotherType, bool replacable) {
        throw new System.NotImplementedException();
    }
}
