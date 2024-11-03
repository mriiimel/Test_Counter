using UnityEngine;
using UnityEngine.UI;

public interface IToggle 
{
    public void ToggleBehaviour(Toggle toggle, GameObject gameObject)
    {
        if (toggle.IsActive())
        {
            if (gameObject.activeSelf == false)
            {
                gameObject.SetActive(true);
            }
        }
    }

}
