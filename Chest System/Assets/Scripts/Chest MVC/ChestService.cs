using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestService : MonoSingleTon<ChestService>
{
    public ChestView chestView;
    public ChestSOList Chests;

    public ChestController CreateNewChest(ChestSO _chestSO, ChestView _chestView)
    {
        ChestModel chestModel = new ChestModel(_chestSO);
        ChestController chestController = new ChestController(_chestView, chestModel);
        return chestController;
    }
}
