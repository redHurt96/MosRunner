using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.Level
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private Timer _timer;
        [SerializeField] private Text _label;

        private void Update() => 
            _label.text = _timer.Time.ToString("F0");
    }
}