using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ChestView : MonoBehaviour
{
    public ChestController chestController;
    public Slot_Controller slotController;

    public Button chestSprite;
    public TextMeshProUGUI chestTypeName;

    private void Start()
    {
        InitializeEmptyChest();
    }

    private void InitializeEmptyChest()
    {
        //chestSprite.image.sprite = null;
    }

    public void SetChestController(ChestController _chestController)
    {
        chestController = _chestController;
    }


}
