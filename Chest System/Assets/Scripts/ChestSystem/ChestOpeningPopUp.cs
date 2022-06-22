using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChestOpeningPopUp : MonoSingleTon<ChestOpeningPopUp>
{
    [SerializeField] public TextMeshProUGUI chestPopUpTitle;
    [SerializeField] public TextMeshProUGUI ExpectedRewardCoins;
    [SerializeField] public TextMeshProUGUI ExpectedRewardGems;

    bool IsTimerRunning;
    internal float unlockTimer;

    private void Update()
    {
        if(IsTimerRunning)
        {
            TimerText();
        }
    }

    private void LateUpdate()
    {
        if(IsTimerRunning)
        {
            ChestService.Instance.CurrentController.chestView.UnlockTime = unlockTimer;
        }
    }

    public void SetChestPopUp(ChestModel _chestModel, ChestView _chestView)
    {
        ChestOpeningPopUp.Instance.chestPopUpTitle.text = _chestView.chestController.chestModel.ChestType.ToString() + " Chest";
        ChestOpeningPopUp.Instance.ExpectedRewardCoins.text = _chestView.chestController.chestModel.MinCoins.ToString() + " - " + _chestView.chestController.chestModel.MaxCoins.ToString();
        ChestOpeningPopUp.Instance.ExpectedRewardGems.text = _chestView.chestController.chestModel.MinGems.ToString() + " - " + _chestView.chestController.chestModel.MaxGems.ToString();

        ChestSystemManager.Instance.ChestPopUpWithTimer.text = _chestView.chestController.chestModel.ChestOpenTime.ToString() + " MIN";
        ChestSystemManager.Instance.CoinRequiredToOpenChest.text = _chestView.chestController.chestModel.CoinRequiredToOpenChest.ToString() + " Coins";
        ChestSystemManager.Instance.GemsRequiredToOpenChest.text = _chestView.chestController.chestModel.GemsRequiredToOpenChest.ToString() + " Gems";
    }

    private void TimerText()
    {
        unlockTimer -= Time.deltaTime;
        float minutes = Mathf.FloorToInt((int)unlockTimer / 60);
        float Seconds = Mathf.FloorToInt((int)unlockTimer % 60);
        ChestSystemManager.Instance.ChestPopUpWithTimer.text = string.Format("Timer: " + "{0:00}:{1:00}", minutes, Seconds);
    }
    
}
