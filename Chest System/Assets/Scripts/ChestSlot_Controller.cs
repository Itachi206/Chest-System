using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestSlot_Controller : MonoBehaviour
{
    private Button[] chestSlotButton;

    void Awake()
    {
        for (int i = 0; i < chestSlotButton.Length; i++)
        {
            chestSlotButton[i] = GetComponentInChildren<Button>();            
        }
    }

    /*private void Update()
    {
        chestSlotButton[2].onClick.AddListener(OnChestSlotClick);
    }*/

    public void OnChestSlot1Click(int slotNumber)
    {
        //chestSlotButton[slotNumber].image.
    }

    public void OnChestSlot2Click()
    {
        Debug.Log(" 2Daba re button");
    }
    public void OnChestSlot3Click()
    {
        Debug.Log(" 3Daba re button");
    }
    public void OnChestSlot4Click()
    {
        Debug.Log(" 4Daba re button");
    }
}
