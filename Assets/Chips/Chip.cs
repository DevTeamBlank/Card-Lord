using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour, IChip {

    ChipType chipType;
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
        GetComponent<SpriteRenderer>().sprite = newSprite;
    }

    // Update is called once per frame
    void Update() {
        // if (clicked)
        //     Choose();
    }

    void Choose() {
        InputManager.Inst.ClickedChip(gameObject);
    }
}
