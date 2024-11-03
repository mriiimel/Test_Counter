using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Starter : MonoBehaviour
{
    [SerializeField] private ItemConfig _itemConfig;
    [SerializeField] private FabrikaModel _fabrikaModel;
    [SerializeField] private Fabrika _fabrika;
    [SerializeField] private MenuButtonController _menuButtonController;
    [Space(10)]
    [SerializeField] private GameObject _panel;
    [Space(10)]
    [SerializeField] private TextMeshProUGUI _baseName;
    [SerializeField] private TextMeshProUGUI _midleName;
    [SerializeField] private TextMeshProUGUI _costlyName;
    [SerializeField] private TextMeshProUGUI _baseCost;
    [SerializeField] private TextMeshProUGUI _midleCost;
    [SerializeField] private TextMeshProUGUI _costlyCost;
    [SerializeField] private TextMeshProUGUI _totalCostText;
    [Space(10)]
    [SerializeField] private BaseButton _baseButtonToBuy;
    [SerializeField] private MidleButton _midleButtonToBuy;
    [SerializeField] private CostlyButton _costlyButtonToBuy;
    [SerializeField] private ClearButtonController _clearButtonController;
    //[Space(10)]
    //[SerializeField] private Toggle _baseToggle;
    //[SerializeField] private Toggle _midleToggle;
    //[SerializeField] private Toggle _costlyToggle;

    //private IToggle m_BaseToggle;
    private TotalCost—ounterController _totalCost;
    void Awake()
    {
        _totalCost = new(_totalCostText);
        _totalCost.ToAwake();   
        _itemConfig.ToAwake();
        _menuButtonController.Construct(_panel);
        _fabrika.Construct(_itemConfig, _fabrikaModel.GetSpawnPosition());
        _baseButtonToBuy.Construct(_totalCost, _itemConfig);
        _midleButtonToBuy.Construct(_totalCost, _itemConfig);
        _costlyButtonToBuy.Construct(_totalCost, _itemConfig);
        _clearButtonController.Construct(_totalCost);
    }


    void Update()
    {
        _totalCost.ToUpdate();
    }
}
