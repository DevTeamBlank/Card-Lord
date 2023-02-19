using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChipManager {

    void UpdateSprite(AgeType ageType); // 칩의 sprite를 변경 - prefab은 게임 도중 변경 불가!!
    void ReceiveChip(ChipType chipType); // 해당 타입을 Intantiate 해서 칩 컨테이너에 추가
    int[] GetPlayedChips(); // 칩이 이동할때마다, 선택지들의 선택 가능 여부를 업데이트
    void RemovePlayedChips(); // 선택지를 선택할 때 낸 칩들을 전부 제거
    public void PlayChip(GameObject chip); // 이 칩이 내졌음
    public void RetrieveChip(GameObject chip); // 이 칩을 다시 가져옴
    void UpdateCurrentChips(); // 현재 칩을 업데이트
}
