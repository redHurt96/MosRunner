using System;
using DG.Tweening;
using UnityEngine;
using static _Project.Logic.Common.ProjectInputService;

namespace _Project.Logic
{
    public class CharacterMovement : MonoBehaviour
    {
        public event Action OnMoveLeft;
        public event Action OnMoveRight;
        
        [SerializeField] private float _limit = 8f;
        [SerializeField] private float _range = 8.5f;
        [SerializeField] private float _duration = .5f;

        private Tween _currentTween;

        private void Update()
        {
            if (_currentTween != null)
                return;
            
            if (LeftButtonPressed)
            {
                float destination = transform.position.x + _range;
                
                if (destination > _limit)
                    return;
                
                _currentTween = transform
                    .DOMoveX(destination, _duration)
                    .OnComplete(() => _currentTween = null);
                
                OnMoveLeft?.Invoke();
            }
            else if (RightButtonPressed)
            {
                float destination = transform.position.x - _range;
                
                if (destination < -_limit)
                    return;
                
                _currentTween = transform
                    .DOMoveX(destination, _duration)
                    .OnComplete(() => _currentTween = null);
                
                OnMoveRight?.Invoke();
            }
        }
    }
}