using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICardManager {

    /* CardManager는 전반적인 카드의 추적, 사용 등을 담당합니다.
     * Card GameObject가 Play 되었을 때 Encounter의 선택지가 선택 가능한지를 확인합니다.
     * Card Type이 다른 Type으로 사용될 수 있는지 체크합니다.
     * Age가 바뀌었을 때 모든 카드들의 Sprite를 업데이트합니다. (TurnManager가 호출)
     * Hand의 카드를 주고 버리게 합니다.
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
