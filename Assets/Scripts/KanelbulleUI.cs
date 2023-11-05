using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class KanelbulleUI : MonoBehaviour
    {
        public TMP_Text label;
        public IntVariable KanelbullarCount;
        void Start()
        {
            KanelbullarCount.ValueChanged.AddListener(OnCountChanged);
            label.text = KanelbullarCount.GetValue().ToString();
        }

        void OnDestroy()
        {
            KanelbullarCount.ValueChanged.RemoveListener(OnCountChanged);
        }

        void OnCountChanged(int newValue)
        {
            label.text = newValue.ToString();
        }
    }
}