using System;
using _Project.Logic.Level;
using DG.Tweening;
using UnityEngine;
using static _Project.Logic.Common.ProjectInputService;

namespace _Project.Logic.Character
{
    public class CharacterMovement : MonoBehaviour
    {
        public event Action OnMoveLeft;
        public event Action OnMoveRight;
        
        [SerializeField] private float _limit = 8f;
        [SerializeField] private float _range = 8.5f;
        [SerializeField] private float _duration = .5f;
        [SerializeField] private LevelManager _levelManager;

        private Tween _currentTween;

        private void Update()
        {
            if (_currentTween != null || _levelManager.GameEnded)
                return;
            
            if (LeftButtonPressed || Input.GetKeyDown(KeyCode.A))
            {
                float destination = transform.position.x + _range;
                
                if (destination > _limit)
                    return;
                
                _currentTween = transform
                    .DOMoveX(destination, _duration)
                    .OnComplete(() => _currentTween = null);
                
                OnMoveLeft?.Invoke();
            }
            else if (RightButtonPressed || Input.GetKeyDown(KeyCode.D))
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