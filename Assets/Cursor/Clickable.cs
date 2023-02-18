using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClickable {
    void OnMouseEnter();
    void OnMouseExit();
    void OnMouseUpAsButton();
    void OnMouseDown();
}
