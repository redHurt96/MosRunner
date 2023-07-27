using System.Collections;
using _Project.Logic.Common;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class EndGameInputDisabler : MonoBehaviour
    {
        [SerializeField] private LevelManager _levelManager;

        private void Start() => 
            _levelManager.OnEnd += Enable;

        private void OnDestroy()
        {
            ProjectInputService.Enable();
            _levelManager.OnEnd -= Enable;
        }

        private void Enable() =>
            StartCoroutine(DisableInput());

        private IEnumerator DisableInput()
        {
            ProjectInputService.Disable();

            yield return new WaitForSeconds(2f);
            
            ProjectInputService.Enable();
        }
    }
}