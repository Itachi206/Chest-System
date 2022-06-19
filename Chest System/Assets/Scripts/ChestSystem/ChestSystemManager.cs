using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChestSystemManager : MonoSingleTon<ChestSystemManager>
{
    [SerializeField] public GameObject ChestPopUp;
    [SerializeField] public TextMeshProUGUI TotalCoins;
    [SerializeField] public TextMeshProUGUI TotalGems;
    
    public void UpdateCoinsUI(int coins)
    {
        TotalCoins.text = coins.ToString();
    }

    public void UpdateGemsUI(int gems)
    {
        TotalGems.text = gems.ToString();
    }
}
