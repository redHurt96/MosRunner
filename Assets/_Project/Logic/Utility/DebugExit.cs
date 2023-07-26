using RH_Utilities.Attributes;
using UnityEngine;
using static _Project.Logic.Common.ProjectInputService;
using static UnityEngine.Application;
using static UnityEngine.Time;

namespace _Project.Logic.Utility
{
    public class DebugExit : MonoBehaviour
    {
        [SerializeField] private float _delay = 1f;
        [SerializeField] private string[] _sequence =
        {
            "left",
            "left",
            "left",
            "right",
            "right",
            "right",
            "up",
            "up",
            "up",
        };

        [SerializeField, ReadOnly] private int _currentCount;
        [SerializeField, ReadOnly] private float _currentDelay;

        private void Update()
        {
            UpdateDelay();
            
            if (LeftButtonPressed)
                Count("left");
            else if (RightButtonPressed)
                Count("right");
            else if (UpButtonPressed)
                Count("up");
        }

        private void UpdateDelay()
        {
            if (_currentCount > 0)
                _currentDelay += deltaTime;

            if (_currentDelay > _delay && _currentCount > 0) 
                _currentCount = 0;
        }

        private void Count(string binding)
        {
            if (binding == _sequence[_currentCount])
            {
                _currentCount++;
                _currentDelay = 0f;

                if (_currentCount == _sequence.Length)
                    Quit();
            }
        }
    }
}
