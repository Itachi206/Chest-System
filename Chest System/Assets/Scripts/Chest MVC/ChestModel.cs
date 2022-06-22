using UnityEngine;

public class ChestModel
{
    public ChestTypeEnum ChestType;
    public Sprite ChestSprite;
    public int MinCoins;
    public int MaxCoins;
    public int MinGems;
    public int MaxGems;
    public int ChestOpenTime;
    public int CoinRequiredToOpenChest;
    public int GemsRequiredToOpenChest;

    public ChestModel(ChestSO _chestSO)
    {
        ChestType = _chestSO.chestType;
        ChestSprite = _chestSO.chestSprite;
        MinCoins = _chestSO.minCoins;
        MaxCoins = _chestSO.maxCoins;
        MinGems = _chestSO.minGems;
        MaxGems = _chestSO.maxGems;
        ChestOpenTime = _chestSO.timeToOpenChest;
        CoinRequiredToOpenChest = _chestSO.coinRequiredToOpenChest;
        GemsRequiredToOpenChest = _chestSO.gemsrequiredToOpenChest;
    }
}
