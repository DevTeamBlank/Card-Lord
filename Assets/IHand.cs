using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHand {

    /* Hand�� �տ� �ִ� ī����� �����մϴ�.
     * EncounterManager�� CardManager���� ��ȣ�ۿ��� ����ϴ�.
     */
    void ReceiveCard(GameObject card);
}