using UnityEngine;

namespace _Project.Logic.SetupScene
{
    public class FirstPoster : MonoBehaviour
    {
        [SerializeField] private GameObject _secondPoster;

        private void OnMouseUpAsButton()
        {
            _secondPoster.SetActive(true);
        }
    }
}