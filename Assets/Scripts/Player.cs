using UnityEngine;


public class Player : MonoBehaviour
{
    bool TryGetPosition(out Vector3 position)
    {
        position = Vector3.zero;
        return true;
    }
    
    public Transform target;
    void Start()
    {
        TryGetPosition(out Vector3 result);
    }
}
