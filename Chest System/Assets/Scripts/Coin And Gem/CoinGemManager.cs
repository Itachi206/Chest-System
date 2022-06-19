using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGemManager : MonoBehaviour
{
    [SerializeField] public int InitialCoins;
    [SerializeField] public int InitialGems;

    private void Start()
    {
        ChestSystemManager.Instance.UpdateCoinsUI(InitialCoins);
        ChestSystemManager.Instance.UpdateGemsUI(InitialGems);
    }
}
