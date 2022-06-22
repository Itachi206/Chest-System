using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedState : ChestState
{
    public override void OnStateEnter(ChestView _chestView)
    {
        ChestService.Instance.CurrentController = _chestView.chestController;
        _chestView.InitializeEmptyChest();
        ReceiveChestRewards(_chestView);
        ChestSystemManager.Instance.ChestPopUp.gameObject.SetActive(false);
        ChestSystemManager.Instance.ChestSlots.SetActive(false);
        ChestSystemManager.Instance.ChestRewardPopUp.SetActive(true);        
        _chestView.slotController.IsSlotEmpty = true;
        _chestView.slotController.chestController.chestModel = null;
        _chestView.slotController.chestController = null;        
        Debug.Log("OPEN HO GAYA");
    }

    private void ReceiveChestRewards(ChestView _chestView)
    {
        int RandomRewardCoin = UnityEngine.Random.Range(_chestView.chestController.chestModel.MinCoins, _chestView.chestController.chestModel.MaxCoins);
        CoinGemManager.Instance.IncreaseCoins(RandomRewardCoin);
        ChestSystemManager.Instance.RewardCoins.text = RandomRewardCoin.ToString();
        int RandomRewardGems = UnityEngine.Random.Range(_chestView.chestController.chestModel.MinGems, _chestView.chestController.chestModel.MaxGems);
        CoinGemManager.Instance.IncreaseGems(RandomRewardGems);
        ChestSystemManager.Instance.RewardGems.text = RandomRewardGems.ToString();
        ChestSystemManager.Instance.ChestRewardPopUpTitle.text = _chestView.chestController.chestModel.ChestType.ToString();                
    }

    public override void OnUpdate(ChestView _chestView)
    {

    }

    public override void OnStateExit(ChestView _chestView)
    {
        ChestSystemManager.Instance.CoinRequiredToOpenChest.gameObject.SetActive(true);
        ChestSystemManager.Instance.CoinButtonTitleName.gameObject.SetActive(true);
        ChestSystemManager.Instance.CoinsOpenButton.interactable = true;
        ChestSystemManager.Instance.ChestPopUpWithTimer.gameObject.SetActive(false);
        //ChestSystemManager.Instance.ChestSlots.SetActive(true);
    }
}
