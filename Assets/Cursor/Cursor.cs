using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour, ICursor {

    public static ICursor Inst;

    private void Awake() {
        Inst = this;
    }

    void Update() {
        transform.position = Input.mousePosition;
    }

    [SerializeField] Sprite[] sprites_ = new Sprite[4];
    public Status currentStatus = Status.general;   

    public void SetStatus(Status newStatus) {
        currentStatus = newStatus;
        GetComponent<SpriteRenderer>().sprite = sprites_[(int)newStatus];
    }
}
