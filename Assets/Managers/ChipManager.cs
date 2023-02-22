using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChipManager : MonoBehaviour, IChipManager {

    public static IChipManager Inst;

    private void Awake() {
        Inst = this;
    }

    void Start() {
        // FixPositions();
    }

    [Header("Ĩ �����̳� + offset �ִ�")]
    [SerializeField] GameObject[] containers_ = new GameObject[7];
    [SerializeField] float containerOffset_;
    [Header("�ʵ� + offset �ִ�")]
    [SerializeField] GameObject field_;
    [SerializeField] float fieldOffset_;
    
    /*
    Vector3[] containerPositions = new Vector3[7];
    Vector3 fieldPosition;

    void FixPositions() {
        for (int i = 0; i < 7; i++) {
            containerPositions[i] = containers_[i].transform.position;
        }        
        fieldPosition = field_.transform.position;
    }
    */

    [Header("Quaternion �ִ�")]
    [SerializeField] float maxQ;

    [Header("���� �ʵ忡 �ִ� Ĩ�� ����")]
    public GameObject[] ChipPrefabs_;

    public void ReceiveChip(ChipType chipType) {
        GameObject newChip = Instantiate(ChipPrefabs_[IndexOf(chipType)], containers_[IndexOf(chipType)].transform);
        newChip.name = "Chip " + chipType.ToString();
        newChip.GetComponent<IChip>().UpdateSprite(GameManager.Inst.GetAge());
        Vector3 pos = new() {
            // x = containerPositions[IndexOf(chipType)].x + Random.Range(-fieldOffset_, fieldOffset_),
            x = Random.Range(-fieldOffset_, fieldOffset_),
            y = 3f,
            // z = containerPositions[IndexOf(chipType)].z + Random.Range(-fieldOffset_, fieldOffset_)
            z = Random.Range(-fieldOffset_, fieldOffset_)
        };
        newChip.transform.SetPositionAndRotation(pos, new Quaternion(Random.Range(0, maxQ), Random.Range(0, maxQ), Random.Range(0, maxQ), Random.Range(0, maxQ)));
    }

    public void RemovePlayedChips() {
        // GameObject[] playedChips = field_.
    }

    int IndexOf(GameObject chip) {
        return (int)chip.GetComponent<IChip>().GetChipType().chipType;
    }

    int IndexOf(ChipType chipType) {
        return (int)chipType.chipType;
    }


    [Header("���� �ʵ忡 �ִ� Ĩ�� ����")]
    [SerializeField] int[] numberOfPlayedChips = new int[7]; // UI�� Ĩ ǥ���� ��, numberOfChips[i] - numberOfPlayedChips[i] �� �����ָ� ��

    public void PlayChip(GameObject chip) {
        numberOfPlayedChips[IndexOf(chip)]++;
        chip.transform.parent = field_.transform;
        Vector3 pos = new() {
            // x = fieldPosition.x + Random.Range(-fieldOffset_, fieldOffset_),
            x = Random.Range(-fieldOffset_, fieldOffset_),
            y = 5f,
            // z = fieldPosition.z + Random.Range(-fieldOffset_, fieldOffset_)
            z = Random.Range(-fieldOffset_, fieldOffset_)
        };
        chip.transform.SetPositionAndRotation(pos, new Quaternion(Random.Range(0, maxQ), Random.Range(0, maxQ), Random.Range(0, maxQ), Random.Range(0, maxQ)));
        GameManager.Inst.UpdateChoice();
    }

    public void RetrieveChip(GameObject chip) {
        numberOfPlayedChips[IndexOf(chip)]--;
        chip.transform.parent = containers_[IndexOf(chip)].transform;
        Vector3 pos = new() {
            // x = containerPositions[IndexOf(chip)].x + Random.Range(-fieldOffset_, fieldOffset_),
            x = Random.Range(-fieldOffset_, fieldOffset_),
            y = 3f,
            // z = containerPositions[IndexOf(chip)].z + Random.Range(-fieldOffset_, fieldOffset_)
            z = Random.Range(-fieldOffset_, fieldOffset_)
        };
        chip.transform.SetPositionAndRotation(pos, new Quaternion(Random.Range(0, maxQ), Random.Range(0, maxQ), Random.Range(0, maxQ), Random.Range(0, maxQ)));
        GameManager.Inst.UpdateChoice();
    }

    public int[] GetPlayedChips() {
        return numberOfPlayedChips;
    }

    public void UpdateSprite(AgeType ageType) {
        GameObject[] chips = GameObject.FindGameObjectsWithTag("Chip");
        foreach (GameObject chip in chips) {
            chip.GetComponent<IChip>().UpdateSprite(ageType);
        }
    }

    [Header("���� �ʵ� + Ĩ �����̳ʿ� �ִ� Ĩ�� ����")]
    [SerializeField] int[] numberOfChips = new int[7];

    public void UpdateCurrentChips() {
        GameManager.Inst.UpdateCurrentChips(numberOfChips);
    }    
}
