using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour, IHand {

    /* Hand�� �տ� �ִ� ī����� �����մϴ�.
     * EncounterManager�� CardManager���� ��ȣ�ۿ��� ����ϴ�.
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
