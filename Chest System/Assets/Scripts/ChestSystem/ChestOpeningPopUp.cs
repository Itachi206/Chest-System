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

    public void SetChestPopUp(ChestModel _chestModel, ChestView _chestView)
    {
        ChestOpeningPopUp.Instance.chestPopUpTitle.text = _chestView.chestController.chestModel.ChestType.ToString() + " Chest";
        ChestOpeningPopUp.Instance.ExpectedRewardCoins.text = _chestView.chestController.chestModel.MinCoins.ToString() + " - " + _chestView.chestController.chestModel.MaxCoins.ToString();
        ChestOpeningPopUp.Instance.ExpectedRewardGems.text = _chestView.chestController.chestModel.MinGems.ToString() + " - " + _chestView.chestController.chestModel.MaxGems.ToString();

        ChestSystemManager.Instance.ChestPopUpWithTimer.text = _chestView.chestController.chestModel.ChestOpenTime.ToString() + " MIN";
        ChestSystemManager.Instance.CoinRequiredToOpenChest.text = _chestView.chestController.chestModel.CoinRequiredToOpenChest.ToString() + " Coins";
        ChestSystemManager.Instance.GemsRequiredToOpenChest.text = _chestView.chestController.chestModel.GemsRequiredToOpenChest.ToString() + " Gems";
    }   
    
}
