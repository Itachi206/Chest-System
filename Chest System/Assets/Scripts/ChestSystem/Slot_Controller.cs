using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot_Controller : MonoBehaviour
{
    public ChestView chestView;
    public bool IsSlotEmpty;

    private void Start()
    {
        //chestView.slotController = this;
        IsSlotEmpty = true;
    }

    public void SpawnRandomChest()
    {
        //ChestService.Instance.CreateNewChest(chestView);
        chestView.gameObject.SetActive(true);
        IsSlotEmpty = false;
    }
}
