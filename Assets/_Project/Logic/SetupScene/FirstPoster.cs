using RH_Utilities.Extensions;
using UnityEngine;

namespace _Project.Logic.SetupScene
{
    public class FirstPoster : MonoBehaviour
    {
        [SerializeField] private GameObject _firstPoster;
        [SerializeField] private GameObject _secondPoster;
        [SerializeField] private GameObject[] _characterButtons;

        private void Update()
        {
            //if (Input.GetKeyDown(_key))
                Interact();
        }

        private void Interact()
        {
            _firstPoster.SetActive(false);
            gameObject.SetActive(false);
            _secondPoster.SetActive(true);
            _characterButtons.ForEach(x => x.SetActive(true));
        }
    }
}