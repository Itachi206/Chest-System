using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChestSystemManager : MonoSingleTon<ChestSystemManager>
{
    [SerializeField] public Button ExitButton;
    [SerializeField] public GameObject ChestPopUp;
    [SerializeField] public TextMeshProUGUI ChestPopUpWithTimer;
    [SerializeField] public TextMeshProUGUI CoinRequiredToOpenChest;
    [SerializeField] public TextMeshProUGUI GemsRequiredToOpenChest;
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

    public void OnOpenNowCoinButtonClick()
    {
        ChestService.Instance.OnCoinButtonClick();
    }

    public void OnOpenNowGemsButtonClick()
    {
        ChestService.Instance.OnGemsButtonClick();
    }

    public void OnExitButtonClick()
    {
        ChestSystemManager.Instance.ChestPopUp.gameObject.SetActive(false);
    }
}
