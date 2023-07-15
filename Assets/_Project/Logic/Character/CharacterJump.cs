using System;
using DG.Tweening;
using UnityEngine;

namespace _Project.Logic
{
    public class CharacterJump : MonoBehaviour
    {
        public event Action OnBegin; 

        [SerializeField] private float _force = 50f;
        [SerializeField] private Rigidbody _rigidbody;
        
        private Tween _currentTween;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                Jump();
        }

        private void Jump()
        {
            _rigidbody.AddForce(Vector3.up * _force);
            OnBegin?.Invoke();
        }
    }
}