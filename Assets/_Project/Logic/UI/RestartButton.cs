using _Project.Logic.Common;
using RH_Utilities.UI;
using static UnityEngine.SceneManagement.SceneManager;

namespace _Project.Logic.UI
{
    public class RestartButton : BaseActionButton
    {
        private void Update()
        {
            if (ProjectInputService.UpButtonPressed)
                Restart();
        }

        protected override void PerformOnClick() => Restart(); 

        private void Restart() => 
            LoadScene(0);
    }
}
