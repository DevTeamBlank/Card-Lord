using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICursor {
    public void SetStatus(Status newStatus);
}

public enum Status {
    general,
    isClickable,
    isClicking
}
