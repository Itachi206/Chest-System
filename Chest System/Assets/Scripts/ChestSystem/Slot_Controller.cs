using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot_Controller : MonoBehaviour
{
    public ChestController chestController;
    [SerializeField] private ChestSOList chestSOList;
    public ChestView chestView;
    public bool IsSlotEmpty;

    private void Start()
    {
        chestView.slotController = this;
        IsSlotEmpty = true;
    }

    public void SpawnRandomChest(ChestSO _chestSO)
    {
        Debug.Log(_chestSO.chestType);
        chestController = ChestService.Instance.CreateNewChest(_chestSO, chestView);
        IsSlotEmpty = false;
    }
}
