using System;
using System.Collections;
using RH_Utilities.Attributes;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class Timer : MonoBehaviour
    {
        private const float START_DELAY = 5f;
        
        public float Time => _originTime - _time < START_DELAY 
            ? START_DELAY - (_originTime - _time) 
            : _time;
        
        [SerializeField] private LevelManager _levelManager;
        [SerializeField] private float _originTime;
        [SerializeField, ReadOnly] private float _time;
        [SerializeField] private GameObject _tutorial;
        
        private Coroutine _routine;

        private void Start()
        {
            _time = _originTime;
            _levelManager.OnEnd += TryBreak;
            _routine = StartCoroutine(TimerRoutine());
        }

        private void OnDestroy()
        {
            _levelManager.OnEnd -= TryBreak;
        }

        private IEnumerator TimerRoutine()
        {
            while (_time > 0f)
            {
                yield return new WaitForSeconds(1f);
                _time--;

                if (_time < _originTime - START_DELAY)
                    _tutorial.SetActive(false);
            }
            
            _levelManager.EndGame();
        }

        private void TryBreak()
        {
            if (_routine != null)
                StopCoroutine(_routine);
            
            _tutorial.SetActive(false);
        }
    }
}