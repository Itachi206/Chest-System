using System;
using UnityEngine;


[CreateAssetMenu(fileName = "ChestSO", menuName = "ScriptableObject/new Chest SO")]
public class ChestSO : ScriptableObject
{
    public ChestTypeEnum chestType;

    public int minCoins;
    public int maxCoins;

    public int minGems;
    public int maxGems;

    public float timeToOpenChest;
}


