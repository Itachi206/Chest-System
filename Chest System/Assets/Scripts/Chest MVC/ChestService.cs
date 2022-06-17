using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestService : MonoSingleTon<ChestService>
{
    public ChestView chestView;
    public ChestSOList Chests;

    public void CreateNewChest(ChestView _chestView)
    {
        int index = UnityEngine.Random.Range(0, Chests.ChestList.Length);
        ChestSO RandomChestSO = Chests.ChestList[index];
        ChestModel chestModel = new ChestModel(RandomChestSO);
        ChestController chestController = new ChestController(_chestView, chestModel);
    }
}
