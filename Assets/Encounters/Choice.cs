using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Choice : MonoBehaviour, IChoice, IClickable {
    [SerializeField] protected readonly int[] requireChips_ = new int[7];

    public int[] GetRequireChips() {
        return requireChips_;
    }

    [SerializeField] protected readonly string text_;
    public string GetText() {
        return text_;
    }

    public virtual void ChooseChoice() {
        // ��� ���� Choice�� Overriding���� ����
        throw new System.NotImplementedException();
    }

    public bool IsChoosable() {
        int[] numberOfPlayedChips = ChipManager.Inst.GetPlayedChips();
        return Judge(numberOfPlayedChips);
    }

    protected virtual bool Judge(int[] numberOfPlayerChips) { // Replacibility�� ���� �����ؾ���
        // ��� ���� Choice�� �ٸ��� ������ �� ���� (e.g. expedition)
        for (int i = 0; i < requireChips_.Length; i++) {
            if (numberOfPlayerChips[i] != requireChips_[i]) {
                return false;
            }
        }
        return true;
    }

    private void Update() {

    }

    public void OnMouseEnter() {
        Cursor.Inst.SetStatus(Status.isClickable);
    }


    public void OnMouseDown() {
        Cursor.Inst.SetStatus(Status.isClicking);
    }

    public void OnMouseUpAsButton() {
        Cursor.Inst.SetStatus(Status.general);
        GameManager.Inst.ClickedChoice(gameObject);
    }

    public void OnMouseExit() {
        Cursor.Inst.SetStatus(Status.general);
    }
}
