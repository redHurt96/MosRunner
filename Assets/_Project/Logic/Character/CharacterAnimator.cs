using _Project.Logic.Level;
using DG.Tweening;
using UnityEngine;

namespace _Project.Logic
{
    public class CharacterAnimator : MonoBehaviour
    {
        [SerializeField] private CharacterJump _jump;
        [SerializeField] private CharacterMovement _movement;
        [SerializeField] private CharacterGroundDetector _groundDetector;
        [SerializeField] private LevelManager _levelManager;
        [SerializeField] private Animator _animator;
        
        private Tween _currentTween;

        private void Start()
        {
            _jump.OnBegin += PlayJump;
            _groundDetector.OnHit += PlayRun;
            _levelManager.OnEnd += PlayFall;
            _movement.OnMoveLeft += PlayMoveLeft;
            _movement.OnMoveRight += PlayMoveRight;
        }

        private void OnDestroy()
        {
            _jump.OnBegin -= PlayJump;
            _groundDetector.OnHit -= PlayRun;
            _levelManager.OnEnd -= PlayFall;
            _movement.OnMoveLeft -= PlayMoveLeft;
            _movement.OnMoveRight -= PlayMoveRight;
        }

        private void PlayJump() => 
            _animator.SetTrigger("Jump");

        private void PlayRun() => 
            _animator.SetTrigger("Run");

        private void PlayFall() => 
            _animator.SetTrigger("Fall");

        private void PlayMoveLeft() => 
            _animator.SetTrigger("MoveLeft");

        private void PlayMoveRight() => 
            _animator.SetTrigger("MoveRight");
    }
}