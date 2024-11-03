using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidleButton : MonoBehaviour
{
    private ItemConfig _itemConfig;
    private TotalCost—ounterController _totalCostController;

    public void Construct(TotalCost—ounterController totalCost—ounterController, ItemConfig itemConfig)
    {
        _totalCostController = totalCost—ounterController;
        _itemConfig = itemConfig;
    }

    public void OnClick()
    {
        _totalCostController.GetCost(_itemConfig.GetItemCost("01"), "01");
    }
}
