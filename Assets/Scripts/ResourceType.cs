using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "ResourceType", menuName = "Kanelbulle/ResourceType", order = 0)]
    public class ResourceType : ScriptableObject
    {
        public Sprite resourceIcon;
        public int goldValue;
        public UnityEvent<int> ValueChanged;
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