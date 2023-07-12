using DG.Tweening;
using UnityEngine;

namespace _Project.Logic
{
    public class CharacterJump : MonoBehaviour
    {
        [SerializeField] private float _force = 50f;
        [SerializeField] private Rigidbody _rigidbody;
        
        private Tween _currentTween;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _rigidbody.AddForce(Vector3.up * _force);
        }
    }
}