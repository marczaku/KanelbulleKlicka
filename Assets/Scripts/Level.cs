using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Level : MonoBehaviour
    {
        public GameController gc;
        private void Update()
        {
            gc.DoUpdate();
        }
    }
}