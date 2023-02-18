using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChipManager {

    void UpdateSprite(int newAge); // prefab, Ĩ �����̳ʿ� �ִ� sprite�� ����
    GameObject ReceiveChip(int chipType); // �ش� Ÿ���� Intantiate �ؼ� Ĩ �����̳ʿ� �߰�
    int[] GetPlayedChips(); // Ĩ�� �̵��Ҷ�����, ���������� ���� ���� ���θ� ������Ʈ
    void RemovePlayedChips(); // �������� ������ �� �� Ĩ���� ���� ����

    void UpdateCurrentChips(int[] numberOfChips); // ���� Ĩ�� ������Ʈ
}
