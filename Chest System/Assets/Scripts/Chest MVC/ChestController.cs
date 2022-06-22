using System;
using UnityEngine;
using System.Threading.Tasks;

public class ChestController
{
    public ChestView chestView;
    public ChestModel chestModel;

    public ChestController(ChestView _chestView, ChestModel _chestModel)
    {
        chestModel = _chestModel;
        chestView = _chestView;
        chestView.chestController = this;
        InitializeLockedChest();
    }

    public void InitializeLockedChest()
    {
        chestView.ChangeState(chestView.lockedState);
    }

    public void OnChestButtonClick()
    {

        ChestSystemManager.Instance.ChestPopUp.SetActive(true);
        //ChestSystemManager.Instance.ChestSlots.SetActive(false);
        //ChestOpeningPopUp.Instance.chestPopUpTitle.text = chestModel.ChestType.ToString() + " Chest";
        //ChestOpeningPopUp.Instance.ExpectedRewardCoins.text = chestModel.MinCoins.ToString() + " - " + chestModel.MaxCoins.ToString();
        //ChestOpeningPopUp.Instance.ExpectedRewardGems.text = chestModel.MinGems.ToString() + " - " + chestModel.MaxGems.ToString();
        chestView.ChangeState(chestView.lockedState);
    }

    public void TimerCountDownFunction()
    {
        chestView.UnlockTime -= 1 * Time.deltaTime;
        Debug.Log(chestView.UnlockTime);
        string totalTimeLeft = "";
        float minutes = Mathf.FloorToInt((int)chestView.UnlockTime / 60);
        totalTimeLeft += minutes.ToString("00") + "M "; 
        float seconds = Mathf.FloorToInt((int)chestView.UnlockTime % 60);
        totalTimeLeft += seconds.ToString("00") + "S ";
        //Debug.Log(totalTimeLeft);
        ChestSystemManager.Instance.ChestPopUpWithTimer.text = totalTimeLeft;



        //Time Disat nhiy 


        //if (IsChestReady())
        //{
        //    ChestSystemManager.Instance.CoinsOpenButton.interactable = true;            
        //    return;
        //}

        //ulong diff = (ulong)(DateTime.Now.Ticks - chestModel.ChestOpenTime);
        //ulong m = diff / TimeSpan.TicksPerMillisecond;

        //float secondsLeft = (float)(chestModel.ChestOpenTime - m) / 1000.0f;

        //string r = "";
        //r += ((int)secondsLeft / 3600).ToString() + "h ";
        //secondsLeft -= ((int)secondsLeft / 3600);
        //r += ((int)secondsLeft / 60).ToString("00") + "m ";

        //r += (secondsLeft % 60).ToString("00") + "s";

        //ChestSystemManager.Instance.ChestPopUpWithTimer.text = r;
        
    }

    //private bool IsChestReady()
    //{
    //    ulong diff = (ulong)(DateTime.Now.Ticks - chestModel.ChestOpenTime);
    //    ulong m = diff / TimeSpan.TicksPerMillisecond;

    //    float secondsLeft = (float)(chestModel.ChestOpenTime - m) / 1000.0f;

    //    if (secondsLeft < 0)
    //    {
    //        ChestSystemManager.Instance.ChestPopUpWithTimer.text = "Ready!";
    //        return true;
    //    }

    //    return false;
    //}
}
