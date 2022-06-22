using UnityEngine;

public abstract class ChestState
{
    public abstract void OnStateEnter(ChestView _chestView);
    public abstract void OnUpdate(ChestView _chestView);
    public abstract void OnStateExit(ChestView _chestView);
}
