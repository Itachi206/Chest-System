using System;
using UnityEngine;

public class ChestController
{
    public ChestView chestView;
    public ChestModel chestModel;

    public ChestController(ChestView _chestView, ChestModel _chestModel)
    {
        chestModel = _chestModel;
        chestView = GameObject.Instantiate<ChestView>(_chestView);

        chestView.SetChestController(this);

        InitializeLockedChest();
    }

    public void InitializeLockedChest()
    {
        chestView.gameObject.SetActive(true);
        chestView.chestSprite.image.sprite = chestModel.ChestSprite;
        chestView.chestTypeName.text = chestModel.ChestType.ToString();
    }
}
