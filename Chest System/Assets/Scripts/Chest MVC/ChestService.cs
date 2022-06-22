using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestService : MonoSingleTon<ChestService>
{
    public ChestController CurrentController;
    public ChestView chestView;
    public ChestSOList Chests;

    public ChestController CreateNewChest(ChestSO _chestSO, ChestView _chestView)
    {
        ChestModel chestModel = new ChestModel(_chestSO);
        ChestController chestController = new ChestController(_chestView, chestModel);
        return chestController;
    }

    public void OnCoinButtonClick()
    {
        CoinGemManager.Instance.DecreaseCoins(CurrentController.chestModel.CoinRequiredToOpenChest);
        CurrentController.chestView.ChangeState(CurrentController.chestView.unlockingState);
    }

    public void OnGemsButtonClick()
    {
        CoinGemManager.Instance.DecreaseCoins(CurrentController.chestModel.GemsRequiredToOpenChest);
        CurrentController.chestView.ChangeState(CurrentController.chestView.unlockedState);
    }
}
