using System.Collections;
using _Project.Logic.Character;
using _Project.Logic.UI;
using RH_Utilities.Attributes;
using RH_Utilities.Extensions;
using RH_Utilities.Level;
using UnityEngine;
using static UnityEngine.Quaternion;

namespace _Project.Logic.Level
{
    public class ItemTrigger : ComponentTrigger<CharacterMovement>
    {
        private const float TIME_SCALE = .3f;
        private const float DURATION = 2f;
        
        [SerializeField, ReadOnly] private string _task;
        [SerializeField] private GameObject _destroyEffect;
        [SerializeField] private CollectedItemNameUIView _name;
        
        private Coroutine _routine;

        public void Install(ItemViewConfig viewConfig)
        {
            _task = viewConfig.Task;
            GetComponentInChildren<MeshRenderer>()
                .materials[1]
                .mainTexture = viewConfig.View;
        }

        protected override void ExecuteOnEnter(CharacterMovement component)
        {
            LevelData levelData = FindObjectOfType<LevelData>();

            TryRunEffect(levelData, component);
            
            levelData.CollectItem(_task);

            Instantiate(_destroyEffect, transform.position, identity, transform.parent);
            Instantiate(_name, GameObject.Find("HUD").transform)
                .With(x => x.Setup(_task));
            
            Destroy(gameObject);
        }

        private void TryRunEffect(LevelData levelData, CharacterMovement characterMovement)
        {
            if (!levelData.IsItemCollected(_task))
            {
                if (_routine != null)
                {
                    characterMovement.StopCoroutine(_routine);
                    _routine = null;
                }

                _routine = characterMovement.StartCoroutine(CollectEffect());
            }
        }

        private IEnumerator CollectEffect()
        {
            Time.timeScale = TIME_SCALE;

            yield return new WaitForSecondsRealtime(DURATION);
            
            Time.timeScale = 1f;
        }
    }
}