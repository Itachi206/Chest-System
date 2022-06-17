using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest_Slots_Controller : MonoBehaviour
{
    public ChestController chestController;

    [SerializeField] private Slot_Controller[] Slots;
    [SerializeField] private ChestSOList chestSOList;

    public void SpawnRandomChest()
    {
        int slot = CheckSlotIsEmpty();
        if (slot == -1)
        {
            Debug.Log("Slots Are full");
            return;
        }
        Debug.Log("Slots are filling" + slot);
        Slots[slot].SpawnRandomChest();
    }

    private int CheckSlotIsEmpty()
    {
        for(int i = 0; i < 4; i++)
        {
            if (Slots[i].IsSlotEmpty)
            {
                return i;
            }
        }
        return -1;
    }
}
