using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Encounter : MonoBehaviour, IEncounter {

    [SerializeField] protected int index_;
    [SerializeField] protected string title_;
    [SerializeField] protected string detail_;
    [SerializeField] protected int possibility_ = 5;

    GameObject[] choices;

    TextMeshProUGUI title;
    TextMeshProUGUI detail;

    void Start() {
        FindChoice();
        FindTMPro();
        DisplayText();
    }

    void FindChoice() {
        choices = new GameObject[transform.childCount];
        for (int i = 0; i < choices.Length; i++) {
            choices[i] = transform.GetChild(i).gameObject;
        }
    }

    void FindTMPro() {
        title = transform.Find("Title").GetComponent<TextMeshProUGUI>();
        detail = transform.Find("Detail").GetComponent<TextMeshProUGUI>();
    }

    void DisplayText() {
        title.text = title_;
        detail.text = detail_;
    }

    public void Encountered() {
        possibility_ = 0;
        encountered = true;
    }

    [SerializeField] protected bool encountered = false;

    public virtual void UpdateEncountablity(int[] numberOfCurrentChips) {
       if (encountered) {
            return;
       }
    }

    public int GetPossibility() {
        return possibility_;
    }

    public void UpdateChoosability() {
       foreach (GameObject choice in choices) {
            choice.GetComponent<IChoice>().UpdateChoosability();
        }
    }
}