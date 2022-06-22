using System;
using UnityEngine;


[CreateAssetMenu(fileName = "ChestSO", menuName = "ScriptableObject/new Chest SO")]
public class ChestSO : ScriptableObject
{
    public ChestTypeEnum chestType;
    public Sprite chestSprite;

    public int minCoins;
    public int maxCoins;

    public int minGems;
    public int maxGems;

    public int timeToOpenChest;
    public int coinRequiredToOpenChest;
    public int gemsrequiredToOpenChest;
}


