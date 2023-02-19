using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameManager {

    // GameManager는 시작하는 메서드를 가짐
    // 나머지 Manager들은 끝나는 메서드를 가짐
    // 다른 Manager들간에는 상호작용 없음 (무조건 GameManager를 통해서 접근)

    // Manager가 행동을 끝냈다는 메서드를 호출하면, 
    // GameManager는 확인 후 새로운 행동을 개시할 것임
    
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
    void UpdateSprite(AgeType newAge); // prefab, 칩 컨테이너에 있는 sprite를 변경
    void ReceiveChip(ChipType chipType); // 해당 타입을 Intantiate 해서 칩 컨테이너에 추가
    int[] GetPlayedChips(); // 칩이 이동할때마다, 선택지들의 선택 가능 여부를 업데이트
    void RemovePlayedChips(); // 선택지를 선택할 때 낸 칩들을 전부 제거
    public void PlayChip(GameObject chip); // 이 칩을 냄
    public void RetrieveChip(GameObject chip); // 이 칩을 다시 가져옴
    void UpdateCurrentChips(int[] numberOfChips); // 현재 칩을 업데이트

}
