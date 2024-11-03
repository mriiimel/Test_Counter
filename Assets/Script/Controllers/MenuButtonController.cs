using UnityEngine;


public class MenuButtonController : MonoBehaviour
{
    private bool m_IsActiv;
    private GameObject m_Panel;

    public void Construct(GameObject panel) 
    { 
        m_Panel = panel;
    }

    
    public void OnStart()
    {
        m_IsActiv = false;
    }

    public void OnClick()
    {
        if (m_IsActiv == false)
        {
            m_Panel.SetActive(true);
            m_IsActiv = true;
        }
        else
        {
            m_Panel.SetActive(false);
            m_IsActiv = false;
        }
            
        
    }
}
