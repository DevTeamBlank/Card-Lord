using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface IChip {

    void SetIsPlayed(bool isPlayed);
    bool GetIsPlayed(); // true: 칩이 이미 내짐, false: 칩이 컨테이너에 있음

    ChipType getChipType();
    void UpdateSprite(Sprite newSprite);

    void PlayChip(); // 칩 컨테이너에서 클릭 시
    void RetrieveChip(); // 이미 낸 칩을 클릭 시
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
