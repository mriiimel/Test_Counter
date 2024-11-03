using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig",menuName = "ScriptableObject/ItemConfig",order = 0)]
public class ItemConfig : ScriptableObject
{
    [SerializeField] private List<ItemConfigModel> _items;

    private Dictionary<string, int> configCost = new();
    private Dictionary<string, string> configName = new();
    private Dictionary<string, GameObject> configGameObject = new();

    private ItemConfigModel _value;
    public List<ItemConfigModel> GetItemArray()
    {
        return _items;
    }
    public ItemConfigModel GetItemConfigModel()
    {
        return _value;
    }
    public int GetItemCost(string ID)
    {
        var value = configCost[ID];
        return value;
    }
    public string GetItemName(string ID)
    {
        var value = configName[ID];
        return value;
    }
    public GameObject GetItemGameObject(string ID)
    {
        var value = configGameObject[ID];
        return value;
    }

    public void ToAwake()
    {
        for (int i = 0; i < _items.Count;i++)
        {
            _value = _items[i];
            configCost.Add(_value.Item_ID.ID, _value.Item_Cost.Cost);
            configName.Add(_value.Item_ID.ID, _value.Item_Name.Name);
            configGameObject.Add(_value.Item_ID.ID, _value.Items.gameObject);
        }
    }
}
