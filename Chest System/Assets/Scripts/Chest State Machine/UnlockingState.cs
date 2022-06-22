using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingState : ChestState
{
    public override void OnStateEnter(ChestView _chestView)
    {
        _chestView.IsTimerRunning = true;
        ChestSystemManager.Instance.CoinRequiredToOpenChest.gameObject.SetActive(false);
        ChestSystemManager.Instance.CoinButtonTitleName.gameObject.SetActive(false);
        //ChestSystemManager.Instance.CoinsOpenButton.interactable = false;
        ChestSystemManager.Instance.ChestPopUpWithTimer.gameObject.SetActive(true);
        ChestService.Instance.CurrentController = _chestView.chestController;
        Debug.Log("UNlocking state");        
        _chestView.UnlockTime = _chestView.chestController.chestModel.ChestOpenTime;
        //ChestOpeningPopUp.Instance.SetChestPopUp(_chestView.chestController.chestModel, _chestView);
    }

    public override void OnUpdate(ChestView _chestView)
    {
        if(_chestView.UnlockTime > 0)
            _chestView.chestController.TimerCountDownFunction();
        else
            _chestView.ChangeState(_chestView.unlockedState);
        //_chestView.chestController.AfterTimerCOuntDownEnded();
    }

    //private void LateUpdate()
    //{
    //    if (IsTimerRunning)
    //    {
    //        ChestService.Instance.CurrentController.chestModel.ChestOpenTime = unlockTimer;
    //    }
    //}

    //private void TimerText()
    //{
    //    unlockTimer -= Time.deltaTime;
    //    float minutes = Mathf.FloorToInt((int)unlockTimer / 60);
    //    float Seconds = Mathf.FloorToInt((int)unlockTimer % 60);
    //    ChestSystemManager.Instance.ChestPopUpWithTimer.text = string.Format("Timer: " + "{0:00}:{1:00}", minutes, Seconds);
    //    if(Seconds <= 0)
    //    {
    //        IsTimerRunning = false;
    //    }
    //}

    public override void OnStateExit(ChestView _chestView)
    {
        ChestSystemManager.Instance.ChestPopUpWithTimer.gameObject.SetActive(false);
    }
}
