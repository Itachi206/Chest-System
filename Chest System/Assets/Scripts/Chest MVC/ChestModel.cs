using UnityEngine;

public class ChestModel
{
    public ChestTypeEnum _ChestType;
    public int _MinCoins;
    public int _MaxCoins;
    public int _MinGems;
    public int _MaxGems;
    public float _ChestOpenTime;

    public ChestModel(ChestSO _chestSO)
    {
        _ChestType = _chestSO.chestType;
        _MinCoins = _chestSO.minCoins;
        _MaxCoins = _chestSO.maxCoins;
        _MinGems = _chestSO.minGems;
        _MaxGems = _chestSO.maxGems;
        _ChestOpenTime = _chestSO.timeToOpenChest;
    }
}
