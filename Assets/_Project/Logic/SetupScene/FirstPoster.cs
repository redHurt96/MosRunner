using RH_Utilities.Extensions;
using RH_Utilities.UI;
using UnityEngine;

namespace _Project.Logic.SetupScene
{
    public class FirstPoster : BaseActionButton
    {
        [SerializeField] private GameObject _firstPoster;
        [SerializeField] private GameObject _secondPoster;
        [SerializeField] private GameObject[] _characterButtons;

        protected override void PerformOnClick()
        {
            _firstPoster.SetActive(false);
            gameObject.SetActive(false);
            _secondPoster.SetActive(true);
            _characterButtons.ForEach(x => x.SetActive(true));
        }
    }
}