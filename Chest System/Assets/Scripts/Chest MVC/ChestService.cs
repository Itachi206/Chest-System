using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestService : MonoBehaviour
{
    public ChestView chestView;
    public ChestSOList Chests;

    private void Start()
    {
        CreateNewChest();
    }

    private void CreateNewChest()
    {
        int index = UnityEngine.Random.Range(0, Chests.ChestList.Length);
        ChestSO RandomChestSO = Chests.ChestList[index];
        ChestModel chestModel = new ChestModel(RandomChestSO);
        ChestController chestController = new ChestController(chestView, chestModel);
    }
}
