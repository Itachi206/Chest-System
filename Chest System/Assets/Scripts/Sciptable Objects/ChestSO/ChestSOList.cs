using System;
using UnityEngine;


[CreateAssetMenu(fileName = "ChestSOList", menuName = "ScriptableObject/new Chest SO List")]
public class ChestSOList : ScriptableObject
{
    [System.Serializable]
    public class ChestLayout
    {
        public ChestTypeEnum ChestTypes;
        public ChestSO ChestSO;
    }

    public ChestLayout[] chestLayouts;
}
