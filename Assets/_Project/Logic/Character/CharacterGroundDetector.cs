using System;
using RH_Utilities.Attributes;
using UnityEngine;
using static UnityEngine.Physics;

namespace _Project.Logic.Character
{
    public class CharacterGroundDetector : MonoBehaviour
    {
        public event Action OnHit;
        [ReadOnly] public bool IsGrounded;
        
        private Vector3 _position => _lowerPoint.position;
        
        [SerializeField] private Transform _lowerPoint;
        [SerializeField] private float _radius;
        [SerializeField] private LayerMask _layerMask;
        
        private void Update()
        {
            bool isGroundedCurrent = OverlapSphere(_position, _radius, _layerMask).Length > 0;
        
            if (isGroundedCurrent && !IsGrounded) 
                OnHit?.Invoke();
        
            IsGrounded = isGroundedCurrent;
        }
    }
}