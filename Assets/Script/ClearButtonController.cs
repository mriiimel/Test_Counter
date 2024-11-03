using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButtonController : MonoBehaviour
{

    private TotalCost—ounterController _totalCost;
    public void Construct(TotalCost—ounterController totalCost—ounterController)
    {
        _totalCost = totalCost—ounterController;
    }

    public void OnClick()
    {
        _totalCost.RemoveCost();
    }
}
