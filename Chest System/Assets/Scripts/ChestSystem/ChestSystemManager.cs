using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChestSystemManager : MonoSingleTon<ChestSystemManager>
{
    [SerializeField] public Button ExitButton;
    [SerializeField] public Button CoinsOpenButton;
    [SerializeField] public Button GemsOpenButton;
    [SerializeField] public GameObject ChestSlots;
    [SerializeField] public GameObject ChestPopUp;
    [SerializeField] public GameObject ChestRewardPopUp;
    [SerializeField] public TextMeshProUGUI CoinButtonTitleName;
    [SerializeField] public TextMeshProUGUI ChestPopUpWithTimer;
    [SerializeField] public TextMeshProUGUI CoinRequiredToOpenChest;
    [SerializeField] public TextMeshProUGUI GemsRequiredToOpenChest;
    [SerializeField] public TextMeshProUGUI TotalCoins;
    [SerializeField] public TextMeshProUGUI TotalGems;

    [SerializeField] public TextMeshProUGUI ChestRewardPopUpTitle;
    [SerializeField] public TextMeshProUGUI RewardCoins;
    [SerializeField] public TextMeshProUGUI RewardGems;

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
        ChestSystemManager.Instance.ChestSlots.SetActive(true);
    }

    public void CloseRewardPopUp()
    {
        ChestSystemManager.Instance.ChestRewardPopUp.gameObject.SetActive(false);
        ChestSystemManager.Instance.ChestSlots.SetActive(true);
    }
}
