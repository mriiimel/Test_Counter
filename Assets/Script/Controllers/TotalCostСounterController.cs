using System.Collections.Generic;
using TMPro;

public class TotalCostСounterController 
{
    private int m_TotalCost = 0;
    private int m_Cost;
    private string m_ID;
    private Dictionary<string, int> m_TotalCostStore = new();
    private TextMeshProUGUI _totalCostText;
    public TotalCostСounterController(TextMeshProUGUI totalCost)
    {
        _totalCostText = totalCost;
    }
    
    public void GetCost(int cost,string ID)
    {
        m_Cost = cost;
        m_ID = ID;
        TotalCost();
    }

    public void RemoveCost()
    {
        m_TotalCost = 0;
        //m_TotalCost -= m_TotalCostStore.GetValueOrDefault(ID);
        //m_TotalCostStore.Remove(ID);
    }

    public void ToAwake()
    {
        _totalCostText.text = m_TotalCost.ToString();
    }

    public void ToUpdate()
    {
        _totalCostText.text = m_TotalCost.ToString();
    }
    
    
    private int TotalCost()
    {
        m_TotalCost += m_Cost;
        if (!m_TotalCostStore.ContainsKey(m_ID))
        {
            m_TotalCostStore.Add(m_ID, m_Cost);
        }
        
        return m_TotalCost;
    }

    
    

}
