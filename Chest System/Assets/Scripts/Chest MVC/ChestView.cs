using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ChestView : MonoBehaviour
{
    public ChestController chestController;
    public Slot_Controller slotController;

    [HideInInspector] public LockedState lockedState = new LockedState();
    [HideInInspector] public UnlockedState unlockedState = new UnlockedState();
    [HideInInspector] public UnlockingState unlockingState = new UnlockingState();
    [HideInInspector] public ChestState currentState;

    public GameObject EmptyChestBox;
    public GameObject FillChestBox;      
    
    public bool IsTimerRunning;
    public float TimeLeft;
    public float UnlockTime;

    public Button chestSprite;
    public TextMeshProUGUI chestTypeName;

    private void Start()
    {
        InitializeEmptyChest();
        InitializeChestState();
    }

    private void Update()
    {
        //if (IsTimerRunning)
        //    chestController.TimerCountDownFunction();
        currentState.OnUpdate(ChestService.Instance.CurrentController.chestView); 
    }    

    private void InitializeChestState()
    {
        currentState = null; ;
        //currentState.OnStateEnter(this);
    }

    public void ChangeState(ChestState _State)
    {
        if (currentState != null)
            currentState.OnStateExit(this);
        currentState = _State;
        currentState.OnStateEnter(this);
    }

    public void InitializeEmptyChest()
    {
        EmptyChestBox.SetActive(true);
        FillChestBox.SetActive(false);
        chestSprite.image.sprite = null;
    }

    public void SetChestController(ChestController _chestController)
    {
        chestController = _chestController;
    }

    public void ChestButtonClick()
    {
        chestController.OnChestButtonClick();
    }

    public void DestroyObject()
    {
        Destroy(this);
    }


}
