using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChestView : MonoBehaviour
{
    public ChestController chestController;
    public Slot_Controller slotController;

    public void SetChestController(ChestController _chestController)
    {
        chestController = _chestController;
    }
}
