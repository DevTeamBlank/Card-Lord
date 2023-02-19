using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounterManager {

    /* EncounterManager는 현재 인카운터와 다음에 뽑힐 인카운터들을 관리합니다.
     * 시대 별, 적절한 상황별로 뽑힐 수 있는지 없는지를 체크합니다.
     * TurnManager가 다음 턴을 시작할 시, 뽑힐 수 있는 인카운터들 중 하나를 랜덤으로 뽑아 Display()합니다.
     * 
     * 
     */

    void FixEncounter(); // 게임 시작 시 한번 호출

    IEncounter GetCurrentEncounter();
    void DrawNextEncounter();

    void UpdateCurrentChips(int[] numberOfChips);
}
