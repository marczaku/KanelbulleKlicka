using UnityEngine;

namespace DefaultNamespace
{
    public class ScriptableObjectDanger : MonoBehaviour
    {
        public ResourceType ResourceType;

        void Start()
        {
            ResourceType.danger = "Be careful with Scriptable Objects!";
        }
    }
}