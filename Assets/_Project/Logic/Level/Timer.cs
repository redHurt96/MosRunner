using System;
using System.Collections;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class Timer : MonoBehaviour
    {
        public float Time => _time;
        
        [SerializeField] private LevelManager _levelManager;
        [SerializeField] private float _time;
        
        private void Start() => 
            StartCoroutine(TimerRoutine());

        private IEnumerator TimerRoutine()
        {
            while (_time > 0f)
            {
                yield return new WaitForSeconds(1f);
                _time--;
            }
            
            _levelManager.EndGame();
        }
    }
}