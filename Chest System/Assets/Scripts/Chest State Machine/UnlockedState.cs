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
        _chestView.slotController.IsSlotEmpty = true;
        _chestView.slotController.chestController = null;
        Debug.Log("OPEN HO GAYA");
    }

    private void ReceiveChestRewards(ChestView _chestView)
    {
        CoinGemManager.Instance.IncreaseCoins(UnityEngine.Random.Range(_chestView.chestController.chestModel.MinCoins, _chestView.chestController.chestModel.MaxCoins));
        CoinGemManager.Instance.IncreaseGems(UnityEngine.Random.Range(_chestView.chestController.chestModel.MinGems, _chestView.chestController.chestModel.MaxGems));
    }

    public override void OnUpdate(ChestView _chestView)
    {

    }

    public override void OnStateExit(ChestView _chestView)
    {

    }
}
