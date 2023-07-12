using RH_Utilities.UI;
using UnityEngine.SceneManagement;

namespace _Project.Logic.SetupScene
{
    public class CharacterSelector : BaseActionButton
    {
        public bool IsMan;
        
        protected override void PerformOnClick()
        {
            CharacterData.IsMan = IsMan;
            SceneManager.LoadScene(1);
        }
    }
}