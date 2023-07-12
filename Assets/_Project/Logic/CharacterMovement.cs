using DG.Tweening;
using UnityEngine;

namespace _Project.Logic
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _limit = 8f;
        [SerializeField] private float _range = 8.5f;
        [SerializeField] private float _duration = .5f;
        
        private Tween _currentTween;

        private void Update()
        {
            if (_currentTween != null)
                return;
            
            if (Input.GetKeyDown(KeyCode.A))
            {
                float destination = transform.position.x + _range;
                
                if (destination > _limit)
                    return;
                
                _currentTween = transform
                    .DOMoveX(destination, _duration)
                    .OnComplete(() => _currentTween = null);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                float destination = transform.position.x - _range;
                
                if (destination < -_limit)
                    return;
                
                _currentTween = transform
                    .DOMoveX(destination, _duration)
                    .OnComplete(() => _currentTween = null);;
            }
        }
    }
}