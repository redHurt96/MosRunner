using UnityEngine;

namespace _Project.Logic.Level
{
    public class TutorialObserver : MonoBehaviour
    {
        [SerializeField] private Timer _timer;
        [SerializeField] private GameObject _tutorial;

        private void Update() => 
            _tutorial.SetActive(_timer.IsCountdown);
    }
}