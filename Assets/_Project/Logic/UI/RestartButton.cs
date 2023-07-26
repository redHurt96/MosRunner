using UnityEngine;
using static _Project.Logic.Common.ProjectInputService;
using static UnityEngine.SceneManagement.SceneManager;

namespace _Project.Logic.UI
{
    public class RestartButton : MonoBehaviour
    {
        private void Update()
        {
            if (UpButtonPressed)
                LoadScene(0);
        }
    }
}
