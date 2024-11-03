using UnityEngine;

public class Fabrika : MonoBehaviour
{
    private ItemConfig m_ItemConfig;
    private Transform m_Spawn;
    public void Construct(ItemConfig itemConfig,Transform spawn)
    {
        
        m_ItemConfig = itemConfig;
        m_Spawn = spawn;
    }

    private void Start()
    {
        for (int i = 0; i < m_ItemConfig.GetItemArray().Count; i++)
        {
            var obj = Instantiate(m_ItemConfig.GetItemConfigModel().Items.gameObject,m_Spawn.position,Quaternion.LookRotation(new Vector3(90,0,0)));
            obj.SetActive(false);
        }
    }

    
    
}
