using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingState : ChestState
{
    public override void OnStateEnter(ChestView _chestView)
    {
        ChestService.Instance.CurrentController = _chestView.chestController;
        Debug.Log("UNlocking state");
        ChestSystemManager.Instance.ChestPopUpWithTimer.text = _chestView.TimeLeft.ToString();
        //ChestOpeningPopUp.Instance.SetChestPopUp(_chestView.chestController.chestModel, _chestView);
    }

    public override void OnUpdate(ChestView _chestView)
    {

    }

    public override void OnStateExit(ChestView _chestView)
    {

    }
}
