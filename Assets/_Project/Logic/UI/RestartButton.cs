using _Project.Logic.Common;
using UnityEngine;
using static UnityEngine.SceneManagement.SceneManager;

namespace _Project.Logic.UI
{
    public class RestartButton : MonoBehaviour
    {
        private void Update()
        {
            if (ProjectInputService.UpButtonPressed)
                LoadScene(0);
        }
    }
}
