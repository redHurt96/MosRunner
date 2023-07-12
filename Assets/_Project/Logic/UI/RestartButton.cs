using RH_Utilities.UI;
using static UnityEngine.SceneManagement.SceneManager;

namespace _Project.Logic.UI
{
    public class RestartButton : BaseActionButton
    {
        protected override void PerformOnClick() => 
            LoadScene(GetActiveScene().buildIndex);
    }
}
