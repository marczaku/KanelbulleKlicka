using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "ResourceType", menuName = "Kanelbulle/ResourceType", order = 0)]
    public class ResourceType : ScriptableObject
    {
        // Serialized. This is Data that should NOT BE CHANGED IN GAMEPLAY
        public Sprite resourceIcon;
        public UnityEvent<int> ValueChanged;
        public string danger;
        private int value;

        public void SetValue(int newValue)
        {
            value = newValue;
            ValueChanged.Invoke(newValue);
        }

        public int GetValue()
        {
            return value;
        }
    }
}