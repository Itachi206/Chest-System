using System;
using UnityEngine;


[CreateAssetMenu(fileName = "ChestSOList", menuName = "ScriptableObject/new Chest SO List")]
public class ChestSOList : ScriptableObject
{
    public ChestSO[] ChestList;
}
