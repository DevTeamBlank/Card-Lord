using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipManager : MonoBehaviour, IChipManager {

    public static IChipManager Inst;

    private void Awake() {
        Inst = this;
    }

    public GameObject[] ChipPrefabs_;

    public GameObject ReceiveChip(ChipType chipType) {
        throw new System.NotImplementedException();
    }

    public void RemovePlayedChips() {
        throw new System.NotImplementedException();
    }

    [ArrayElementTitle("chipType")]
    [SerializeField] int[] numberOfPlayedChips = new int[7]; // UI�� Ĩ ǥ���� ��, numberOfChips[i] - numberOfPlayedChips[i] �� �����ָ� ��

    public int[] GetPlayedChips() {
        return numberOfPlayedChips;
    }

    [ArrayElementTitle("chipType")]
    [SerializeField] readonly Sprite[,] sprites_ = new Sprite[4,7];

    public void UpdateSprite(int newAge) {
        throw new System.NotImplementedException();
    }

    [ArrayElementTitle("chipType")]
    [SerializeField] int[] numberOfChips = new int[7];

    public void UpdateCurrentChips(int[] numberOfChips) { // EncounterManager
        throw new System.NotImplementedException();
    }
}
