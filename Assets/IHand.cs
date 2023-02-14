using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHand {

    /* Hand는 손에 있는 카드들을 관리합니다.
     * EncounterManager나 CardManager와의 상호작용이 잦습니다.
     */
    void ReceiveCard(GameObject card);
}