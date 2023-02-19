using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameManager {

    // GameManager�� �����ϴ� �޼��带 ����
    // ������ Manager���� ������ �޼��带 ����
    // �ٸ� Manager�鰣���� ��ȣ�ۿ� ���� (������ GameManager�� ���ؼ� ����)

    // Manager�� �ൿ�� ���´ٴ� �޼��带 ȣ���ϸ�, 
    // GameManager�� Ȯ�� �� ���ο� �ൿ�� ������ ����
    
    void GameStart();

    int GetRandom(int offset, int maxValue); // please note that maxValue is exclusive
    bool GetAllowInput();
    void SetAllowInput(bool allow);

    // TurnManager.Inst
    public AgeType GetAge();

    public void AgeEnd();

    public int GetTurn();

    public void TurnEnd();

    // EncounterManager.Inst
    IEncounter GetCurrentEncounter();
    void DrawNextEncounter();


    // InputManager.Inst

    void ClickedChip(GameObject chip);
    void ClickedChoice(GameObject choice);
    

    // ChipManager.Inst
    void UpdateSprite(AgeType newAge); // prefab, Ĩ �����̳ʿ� �ִ� sprite�� ����
    void ReceiveChip(ChipType chipType); // �ش� Ÿ���� Intantiate �ؼ� Ĩ �����̳ʿ� �߰�
    int[] GetPlayedChips(); // Ĩ�� �̵��Ҷ�����, ���������� ���� ���� ���θ� ������Ʈ
    void RemovePlayedChips(); // �������� ������ �� �� Ĩ���� ���� ����
    public void PlayChip(GameObject chip); // �� Ĩ�� ��
    public void RetrieveChip(GameObject chip); // �� Ĩ�� �ٽ� ������
    void UpdateCurrentChips(int[] numberOfChips); // ���� Ĩ�� ������Ʈ

}
