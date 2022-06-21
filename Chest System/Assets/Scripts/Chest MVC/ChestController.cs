using System;
using UnityEngine;
using System.Threading.Tasks;

public class ChestController
{
    public ChestView chestView;
    public ChestModel chestModel;

    public ChestController(ChestView _chestView, ChestModel _chestModel)
    {
        chestModel = _chestModel;
        chestView = _chestView;
        chestView.chestController = this;
        InitializeLockedChest();
    }

    public void InitializeLockedChest()
    {
        chestView.ChangeState(chestView.lockedState);
    }

    public void OnChestButtonClick()
    {

        ChestSystemManager.Instance.ChestPopUp.SetActive(true);
        //ChestOpeningPopUp.Instance.chestPopUpTitle.text = chestModel.ChestType.ToString() + " Chest";
        //ChestOpeningPopUp.Instance.ExpectedRewardCoins.text = chestModel.MinCoins.ToString() + " - " + chestModel.MaxCoins.ToString();
        //ChestOpeningPopUp.Instance.ExpectedRewardGems.text = chestModel.MinGems.ToString() + " - " + chestModel.MaxGems.ToString();
        chestView.ChangeState(chestView.lockedState);
    }

    public void TimerCountDownFunction()
    {
        chestView.UnlockTime -= Time.deltaTime;
        float minutes = Mathf.FloorToInt((int)chestView.UnlockTime / 60);
        float seconds = Mathf.FloorToInt((int)chestView.UnlockTime % 60);
        ChestSystemManager.Instance.ChestPopUpWithTimer.text = String.Format("00:00", minutes, seconds);
    }

    public async void TimerStateFunction()
    {
        TimeSpan ts = TimeSpan.FromSeconds(chestView.UnlockTime);

        await Task.Delay(ts);
        if(chestView.currentState == chestView.unlockingState)
        {
            chestView.ChangeState(chestView.unlockedState);    
        }
    }
}
