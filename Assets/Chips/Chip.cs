using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour, IChip, IClickable {

    [SerializeField] ChipType chipType;
    [SerializeField] bool isPlayed = false;

    public ChipType getChipType() {
        return chipType;
    }
    public bool GetIsPlayed() {
        return isPlayed;
    }
    public void SetIsPlayed(bool isPlayed) {
        this.isPlayed = isPlayed;
    }

    public void PlayChip() {
        SetIsPlayed(true);
        throw new System.NotImplementedException();
    }

    public void RetrieveChip() {
        SetIsPlayed(false);
        throw new System.NotImplementedException();
    }    

    public void UpdateSprite(Sprite newSprite) {
        transform.Find("TopSprite").GetComponent<SpriteRenderer>().sprite = newSprite;
        transform.Find("BottomSprite").GetComponent<SpriteRenderer>().sprite = newSprite;
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
