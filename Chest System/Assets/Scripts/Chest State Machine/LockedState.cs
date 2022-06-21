using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedState : ChestState
{
    public override void OnStateEnter(ChestView _chestView)
    {
        ChestService.Instance.CurrentController = _chestView.chestController;
        _chestView.EmptyChestBox.SetActive(false);
        _chestView.FillChestBox.SetActive(true);
        _chestView.chestSprite.image.sprite = _chestView.chestController.chestModel.ChestSprite;
        _chestView.chestTypeName.text = _chestView.chestController.chestModel.ChestType.ToString();

        ChestOpeningPopUp.Instance.SetChestPopUp(_chestView.chestController.chestModel, _chestView);
        //ChestOpeningPopUp.Instance.chestPopUpTitle.text = _chestView.chestController.chestModel.ChestType.ToString() + " Chest";
        //ChestOpeningPopUp.Instance.ExpectedRewardCoins.text = _chestView.chestController.chestModel.MinCoins.ToString() + " - " + _chestView.chestController.chestModel.MaxCoins.ToString();
        //ChestOpeningPopUp.Instance.ExpectedRewardGems.text = _chestView.chestController.chestModel.MinGems.ToString() + " - " + _chestView.chestController.chestModel.MaxGems.ToString();
        
        //ChestSystemManager.Instance.ChestPopUpWithTimer.text = _chestView.chestController.chestModel.ChestOpenTime.ToString() + " MIN";
        //ChestSystemManager.Instance.CoinRequiredToOpenChest.text = _chestView.chestController.chestModel.CoinRequiredToOpenChest.ToString() + " Coins";
        //ChestSystemManager.Instance.GemsRequiredToOpenChest.text = _chestView.chestController.chestModel.GemsRequiredToOpenChest.ToString() + " Gems";
    }

    public override void OnUpdate(ChestView _chestView)
    {
        
    }

    public override void OnStateExit(ChestView _chestView)
    {
        
    }
}
