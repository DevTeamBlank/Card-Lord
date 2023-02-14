using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour, IHand {

    /* Hand는 손에 있는 카드들을 관리합니다.
     * EncounterManager나 CardManager와의 상호작용이 잦습니다.
     */

    public static IHand Inst;

    private void Awake() {
        Inst = this;
    }


    [SerializeField] private GameObject[] cards = new GameObject[100];
    [SerializeField] private CardType[] numberOfCards;

    public void ReceiveCard(GameObject card) {
        throw new System.NotImplementedException();
    }


    // Update is called once per frame
    void Update() {

    }
}
