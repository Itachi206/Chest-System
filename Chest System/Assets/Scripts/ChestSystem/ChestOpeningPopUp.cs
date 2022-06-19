using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChestOpeningPopUp : MonoSingleTon<ChestOpeningPopUp>
{
    [SerializeField] public Button ExitButton;

    public void OnExitButtonClick()
    {
        ChestSystemManager.Instance.ChestPopUp.gameObject.SetActive(false);
    }
}
