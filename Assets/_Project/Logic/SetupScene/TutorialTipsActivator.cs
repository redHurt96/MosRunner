using RH_Utilities.Extensions;
using UnityEngine;

namespace _Project.Logic.SetupScene
{
    public class TutorialTipsActivator : MonoBehaviour
    {
        [SerializeField] private GameObject[] _tips;

        private void OnEnable() => 
            _tips
                .ForEach(x => x.SetActive(true));
    }
}