using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounterManager {

    /* EncounterManager�� ���� ��ī���Ϳ� ������ ���� ��ī���͵��� �����մϴ�.
     * �ô� ��, ������ ��Ȳ���� ���� �� �ִ��� �������� üũ�մϴ�.
     * TurnManager�� ���� ���� ������ ��, ���� �� �ִ� ��ī���͵� �� �ϳ��� �������� �̾� Display()�մϴ�.
     * 
     * 
     */

    Encounter GetCurrentEncounter();
    void DrawNextEncounter();


}
