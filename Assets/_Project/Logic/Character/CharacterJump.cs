using System;
using UnityEngine;
using static _Project.Logic.Common.ProjectInputService;
using static UnityEngine.Vector3;

namespace _Project.Logic.Character
{
    public class CharacterJump : MonoBehaviour
    {
        public event Action OnBegin; 

        [SerializeField] private float _force = 50f;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private CharacterGroundDetector _groundDetector;

        private void Update()
        {
            if (!_groundDetector.IsGrounded)
                return;
            
            if (UpButtonPressed) 
                Jump();
        }

        private void Jump()
        {
            _rigidbody.AddForce(up * _force);
            OnBegin?.Invoke();
        }
    }
}