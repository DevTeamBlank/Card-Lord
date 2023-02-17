using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface IChip {

    void SetIsPlayed(bool isPlayed);
    bool GetIsPlayed(); // true: Ĩ�� �̹� ����, false: Ĩ�� �����̳ʿ� ����

    ChipType getChipType();
    void UpdateSprite(Sprite newSprite);

    void PlayChip(); // Ĩ �����̳ʿ��� Ŭ�� ��
    void RetrieveChip(); // �̹� �� Ĩ�� Ŭ�� ��
}

[System.Serializable]
public struct ChipType {
    public enum ChipName {
        gold,
        food,
        resource,
        civil,
        military,
        karma,
        heritage
    }

    [SerializeField]
    public ChipName chipType;
}
