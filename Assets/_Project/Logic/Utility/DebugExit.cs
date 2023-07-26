using UnityEngine;
using static UnityEngine.Application;
using static UnityEngine.Input;

namespace _Project.Logic.Utility
{
    public class DebugExit : MonoBehaviour
    {
        private void Update()
        {
            if (GetButtonDown("Fire1") && GetButtonDown("Fire2"))
                Quit();
        }
    }
}
