using UnityEngine;

public class FabrikaModel : MonoBehaviour
{
    [SerializeField] private Transform _spawn;
    
    public Transform GetSpawnPosition()
    {
        return _spawn;
    }

    
}
