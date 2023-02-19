using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IGameManager {

    [SerializeField] int seed;

    public static IGameManager Inst;

    private void Awake() {
        Inst = this;
    }

    [SerializeField] bool allowInput = true;

    public void SetAllowInput(bool allow) {
        allowInput = allow;
    }

    public bool GetAllowInput() {
        return allowInput;
    }

    public void GameStart() {
        SetSeed();
        AgeStart();
    }

    public void AgeEnd() {
        AgeStart();
    }

    void AgeStart() {
        TurnManager.Inst.AgeStart();
        EncounterManager.Inst.FixEncounter();
        ChipManager.Inst.UpdateSprite(TurnManager.Inst.GetAge());
    }

    void SetSeed() {
        seed = new System.Random().Next(0, 100);
    }

    public int GetRandom(int offset, int maxValue) {
        System.Random random = new System.Random(seed + (int) TurnManager.Inst.GetAge().ageType * 71 + TurnManager.Inst.GetTurn() * 17 + offset);
        return random.Next(0, maxValue);
    }

    public AgeType GetAge() {
        return TurnManager.Inst.GetAge();
    }

    public int GetTurn() {
        return TurnManager.Inst.GetTurn();
    }

    public IEncounter GetCurrentEncounter() {
        return EncounterManager.Inst.GetCurrentEncounter();
    }

    public void DrawNextEncounter() {
        EncounterManager.Inst.DrawNextEncounter();
    }

    public void UpdateSprite(AgeType newAge) {
        ChipManager.Inst.UpdateSprite(newAge);
    }

    public void ReceiveChip(ChipType chipType) {
        ChipManager.Inst.ReceiveChip(chipType);
    }

    public int[] GetPlayedChips() {
        return ChipManager.Inst.GetPlayedChips();
    }

    public void RemovePlayedChips() {
        ChipManager.Inst.RemovePlayedChips();
    }

    public void PlayChip(GameObject chip) {
        ChipManager.Inst.PlayChip(chip);
    }

    public void RetrieveChip(GameObject chip) {
        ChipManager.Inst.RetrieveChip(chip);
    }

    public void UpdateCurrentChips(int[] numberOfChips) {
        EncounterManager.Inst.UpdateCurrentChips(numberOfChips);
    }

   

    public void TurnEnd() {
        TurnManager.Inst.TurnStart();
    }

    public void ClickedChip(GameObject chip) {
        InputManager.Inst.ClickedChip(chip);
    }

    public void ClickedChoice(GameObject choice) {
        InputManager.Inst.ClickedChoice(choice);
    }
}
