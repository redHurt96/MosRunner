using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.Level
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private Timer _timer;
        [SerializeField] private Text _timeText;
        [SerializeField] private Text _countDownText;

        private void Update()
        {
            _timeText.text = _timer.Time.ToString("F0");
            _countDownText.text = _timer.Time.ToString("F0");

            _timeText.enabled = !_timer.IsCountdown;
            _countDownText.enabled = _timer.IsCountdown;
        }
    }
}