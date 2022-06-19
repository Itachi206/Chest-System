using System;
using UnityEngine;

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
        chestView.EmptyChestBox.SetActive(false);
        chestView.FillChestBox.SetActive(true);
        chestView.chestSprite.image.sprite = chestModel.ChestSprite;
        chestView.chestTypeName.text = chestModel.ChestType.ToString();
    }

    public void OnChestButtonClick()
    {
        ChestSystemManager.Instance.ChestPopUp.SetActive(true);
        Debug.Log("Chest pe Click ho raha hai benchod");
    }
}
