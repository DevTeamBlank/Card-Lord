using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IGameManager
{
    public static IGameManager Inst;

    private void Awake() {
        Inst = this;
    }


    [SerializeField] bool allowInput = true;

    public void SetAllowInput(bool allow) {
        allowInput = allow;
    }

    public bool GetAllowInput() {
        return allowInput;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
