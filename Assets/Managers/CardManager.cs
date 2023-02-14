using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour, ICardManager {

    /* CardManager는 전반적인 카드의 추적, 사용 등을 담당합니다.
     * Card GameObject가 Play 되었을 때 Encounter의 선택지가 선택 가능한지를 확인합니다.
     * Card Type이 다른 Type으로 사용될 수 있는지 체크합니다.
     * Age가 바뀌었을 때 모든 카드들의 Sprite를 업데이트합니다. (TurnManager가 호출)
     * Hand의 카드를 주고 버리게 합니다.
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
