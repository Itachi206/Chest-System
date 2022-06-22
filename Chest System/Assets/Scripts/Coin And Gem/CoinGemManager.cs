using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGemManager : MonoSingleTon<CoinGemManager>
{
    [SerializeField] public int InitialCoins;
    [SerializeField] public int InitialGems;

    private void Start()
    {
        ChestSystemManager.Instance.UpdateCoinsUI(InitialCoins);
        ChestSystemManager.Instance.UpdateGemsUI(InitialGems);
    }

    public void IncreaseCoins(int _coins)
    {
        InitialCoins += _coins;
        ChestSystemManager.Instance.UpdateCoinsUI(InitialCoins);
    }

    public void IncreaseGems(int _gems)
    {
        InitialGems += _gems;
        ChestSystemManager.Instance.UpdateGemsUI(InitialGems);
    }

    public void DecreaseCoins(int _coins)
    {
        InitialCoins -= _coins;
        ChestSystemManager.Instance.UpdateCoinsUI(InitialCoins);
    }

    public void DecreaseGems(int _gems)
    {
        InitialGems -= _gems;
        ChestSystemManager.Instance.UpdateGemsUI(InitialGems);
    }
}
