using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour, IHandManager
{
    public static IHandManager Inst;

    private void Awake() {
        Inst = this;
    }



}
