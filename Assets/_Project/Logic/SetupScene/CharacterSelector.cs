using _Project.Logic.Common;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Logic.SetupScene
{
    public class CharacterSelector : MonoBehaviour
    {
        [SerializeField] private Transform _leftButton;
        [SerializeField] private Transform _rightButton;
        [SerializeField] private Side _side = Side.Left;
        [SerializeField] private float _scaleUpSize = 1.1f;
        [SerializeField] private float _scaleUpDuration = .5f;

        private void Start() => 
            _leftButton.DOScale(Vector3.one * _scaleUpSize, _scaleUpDuration);

        private void Update()
        {
            if (ProjectInputService.LeftButtonPressed && _side is Side.Right)
            {
                _leftButton.DOScale(Vector3.one * _scaleUpSize, _scaleUpDuration);
                _rightButton.DOScale(Vector3.one, _scaleUpDuration);

                _side = Side.Left;
            }
            else if (ProjectInputService.RightButtonPressed && _side is Side.Left)
            {
                _rightButton.DOScale(Vector3.one * _scaleUpSize, _scaleUpDuration);
                _leftButton.DOScale(Vector3.one, _scaleUpDuration);
                
                _side = Side.Right;
            }
            else if (ProjectInputService.UpButtonPressed)
            {
                CharacterData.IsMale = _side is Side.Right;
                SceneManager.LoadScene(1);
            }
        }
    }

    public enum Side : byte
    {
        Left = 0,
        Right,
    }
}