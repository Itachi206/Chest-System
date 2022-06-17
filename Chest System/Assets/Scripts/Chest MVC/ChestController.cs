using UnityEngine;

public class ChestController
{
    public ChestView chestView;
    public ChestModel chestModel;

    public ChestController(ChestView _chestView, ChestModel _chestModel)
    {
        chestModel = _chestModel;
        chestView = GameObject.Instantiate<ChestView>(_chestView);

        chestView.SetChestController(this);
    }
}
