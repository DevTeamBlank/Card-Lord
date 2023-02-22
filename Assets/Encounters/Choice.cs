using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Choice : MonoBehaviour, IChoice, IClickable {

    [SerializeField] protected int[] requireChips_ = new int[7];
    [SerializeField] protected int[] rewardChips_ = new int[7];
    [SerializeField] protected Sprite choosableSprite_;
    protected Sprite sprite;

    [SerializeField] protected string text_;
    [SerializeField] protected bool choosability = false;

    private TextMeshProUGUI text;
    private TextMeshProUGUI require;
    private TextMeshProUGUI reward;

    private void Start() {
        sprite = GetComponent<SpriteRenderer>().sprite;
        FindTMPro();
        DisplayText();
    }

    void FindTMPro() {
        text = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        require = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        reward = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
    }

    protected virtual void DisplayText() {
        // ��� ���� Choice�� Overriding���� ���� ���� (ex. �߰� ����, ���๰ ��)
        text.text = text_;
        require.text = ToString(requireChips_);
        reward.text = ToString(rewardChips_);
    }

    public string ToString(int[] chips) {
        string ret = "";
        for (int i = 0; i < 7; i++) {
            for (int j = 0; j < chips[i]; j++) {
                ret += "<sprite=" + i + ">";
            }
        }
        return ret;
    }

    public int[] GetRequireChips() {
        return requireChips_;
    }

    public virtual void ChooseChoice() {
        // ��� ���� Choice�� Overriding���� ����
        throw new System.NotImplementedException();
    }

    public void UpdateChoosability() {
        int[] numberOfPlayedChips = ChipManager.Inst.GetPlayedChips();
        choosability = Judge(numberOfPlayedChips);
        if (choosability) {
            GetComponent<SpriteRenderer>().sprite = choosableSprite_;
        } else {
            GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }

    protected virtual bool Judge(int[] numberOfPlayedChips) { // Replacibility�� ���� �����ؾ���
        // ��� ���� Choice�� �ٸ��� ������ �� ���� (e.g. expedition, �߰� ����, �ǹ�)
        for (int i = 0; i < requireChips_.Length; i++) {
            if (numberOfPlayedChips[i] != requireChips_[i]) {
                return false;
            }
        }
        return true;
    }

    public void OnMouseEnter() {
        Cursor.Inst.SetStatus(Status.isClickable);
    }


    public void OnMouseDown() {
        Cursor.Inst.SetStatus(Status.isClicking);
    }

    public void OnMouseUpAsButton() {
        Cursor.Inst.SetStatus(Status.general);
        if (choosability) {           
            GameManager.Inst.ClickedChoice(gameObject);
        }        
    }

    public void OnMouseExit() {
        Cursor.Inst.SetStatus(Status.general);
    }
}
