using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace _Project.Logic.Level
{
    public class EndGamePostProcess : MonoBehaviour
    {
        [SerializeField] private LevelManager _levelManager;
        [SerializeField] private PostProcessVolume _volume;

        private void Start() => 
            _levelManager.OnEnd += Enable;

        private void OnDestroy() => 
            _levelManager.OnEnd -= Enable;

        private void Enable() =>
            StartCoroutine(IncreaseWeight());

        private IEnumerator IncreaseWeight()
        {
            float time = 0f;

            while (time < 1f)
            {
                time += Time.deltaTime;
                _volume.weight = time;

                yield return null;
            }

            _volume.weight = 1f;
        }
    }
}