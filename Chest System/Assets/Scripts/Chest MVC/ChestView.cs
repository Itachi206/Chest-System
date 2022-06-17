using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestView : MonoBehaviour
{
    public ChestController chestController;

    public void SetChestController(ChestController _chestController)
    {
        chestController = _chestController;
    }
}
