using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChestOpeningPopUp : MonoSingleTon<ChestOpeningPopUp>
{
    [SerializeField] public Button ExitButton;
    [SerializeField] public TextMeshProUGUI chestPopUpTitle;
    [SerializeField] public TextMeshProUGUI ExpectedRewardCoins;
    [SerializeField] public TextMeshProUGUI ExpectedRewardGems;


    public void OnExitButtonClick()
    {
        ChestSystemManager.Instance.ChestPopUp.gameObject.SetActive(false);
    }
}
