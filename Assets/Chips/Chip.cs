using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour, IChip, IClickable {

    [SerializeField] protected ChipType chipType;
    [SerializeField] bool isPlayed = false;
    [SerializeField] protected Sprite[] sprites_;

    public ChipType GetChipType() {
        return chipType;
    }
    public bool GetIsPlayed() {
        return isPlayed;
    }
    
    void SetIsPlayed(bool isPlayed) {
        this.isPlayed = isPlayed;
    }

    public void PlayChip() {
        SetIsPlayed(true);
        GameManager.Inst.PlayChip(gameObject);
    }

    public void RetrieveChip() {
        SetIsPlayed(false);
        GameManager.Inst.RetrieveChip(gameObject);
    }    

    int IndexOf(AgeType ageType) {
        return (int)ageType.ageType;
    }

    public void UpdateSprite(AgeType ageType) {
        transform.Find("TopSprite").GetComponent<SpriteRenderer>().sprite = sprites_[IndexOf(ageType)];
        transform.Find("BottomSprite").GetComponent<SpriteRenderer>().sprite = sprites_[IndexOf(ageType)];
    }

    public void OnMouseEnter() {
        Cursor.Inst.SetStatus(Status.isClickable);
    }
    

    public void OnMouseDown() {
        Cursor.Inst.SetStatus(Status.isClicking);        
    }

    public void OnMouseUpAsButton() {
        Cursor.Inst.SetStatus(Status.general);
        GameManager.Inst.ClickedChip(gameObject);
    }

    public void OnMouseExit() {
        Cursor.Inst.SetStatus(Status.general);
    }
}
