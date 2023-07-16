using UnityEngine;
using static _Project.Logic.Common.ProjectInputService;

namespace _Project.Logic.SetupScene
{
    public class Poster : MonoBehaviour
    {
        [SerializeField] private GameObject _next;

        private void Update()
        {
            if (UpButtonPressed)
                Interact();
        }

        private void Interact()
        {
            _next.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}