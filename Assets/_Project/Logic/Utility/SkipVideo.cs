using _Project.Logic.Common;
using RH_Utilities.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace _Project.Logic.Utility
{
    public class SkipVideo : MonoBehaviour
    {
        [SerializeField] private UnityEvent _event;
        
        [SerializeField] private float _delay = 1f;
        [SerializeField] private string[] _sequence =
        {
            "right",
        };

        [SerializeField, ReadOnly] private int _currentCount;
        [SerializeField, ReadOnly] private float _currentDelay;

        private void Update()
        {
            UpdateDelay();
            
            if (ProjectInputService.LeftButtonPressed)
                Count("left");
            else if (ProjectInputService.RightButtonPressed)
                Count("right");
            else if (ProjectInputService.UpButtonPressed)
                Count("up");
        }

        private void UpdateDelay()
        {
            if (_currentCount > 0)
                _currentDelay += Time.deltaTime;

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
                    _event.Invoke();
            }
        }
    }
}