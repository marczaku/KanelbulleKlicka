using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "Kanelbulle/IntVariable", order = 0)]
    public class IntVariable : ScriptableObject
    {
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