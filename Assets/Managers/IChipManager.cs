using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChipManager {

    void UpdateSprite(int newAge); // prefab, 칩 컨테이너에 있는 sprite를 변경
    GameObject ReceiveChip(int chipType); // 해당 타입을 Intantiate 해서 칩 컨테이너에 추가
    int[] GetPlayedChips(); // 칩이 이동할때마다, 선택지들의 선택 가능 여부를 업데이트
    void RemovePlayedChips(); // 선택지를 선택할 때 낸 칩들을 전부 제거

    void UpdateCurrentChips(int[] numberOfChips); // 현재 칩을 업데이트
}
