using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChipManager {

    void UpdateSprite(AgeType ageType); // Ĩ�� sprite�� ���� - prefab�� ���� ���� ���� �Ұ�!!
    void ReceiveChip(ChipType chipType); // �ش� Ÿ���� Intantiate �ؼ� Ĩ �����̳ʿ� �߰�
    int[] GetPlayedChips(); // Ĩ�� �̵��Ҷ�����, ���������� ���� ���� ���θ� ������Ʈ
    void RemovePlayedChips(); // �������� ������ �� �� Ĩ���� ���� ����
    public void PlayChip(GameObject chip); // �� Ĩ�� ������
    public void RetrieveChip(GameObject chip); // �� Ĩ�� �ٽ� ������
    void UpdateCurrentChips(); // ���� Ĩ�� ������Ʈ
}
