using UnityEngine;

public class PlController : MonoBehaviour
{
    private Vector3 scale;
    
    
    private Vector3 _scale;

    private Vector3 GetScale() => _scale;

    private void SetScale(Vector3 value) => _scale = value;

    public Vector3 Scale
    {
        get => _scale;
        set => _scale = value;
    }


    void FixPosition(ref Vector3 position) // see below
    {
        position.y = 0;
    }
    
    void Start()
    {
        Vector3 position = transform.position; // 1 2 3
        FixPosition(ref position);
        transform.position = position;
    }
}