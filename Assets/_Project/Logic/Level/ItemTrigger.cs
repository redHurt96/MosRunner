using _Project.Logic.Character;
using RH_Utilities.Attributes;
using RH_Utilities.Level;
using UnityEngine;
using static UnityEngine.Quaternion;

namespace _Project.Logic.Level
{
    public class ItemTrigger : ComponentTrigger<CharacterMovement>
    {
        [SerializeField, ReadOnly] private string _task;
        [SerializeField] private GameObject _destroyEffect;

        public void Install(ItemViewConfig viewConfig)
        {
            _task = viewConfig.Task;
            GetComponentInChildren<MeshRenderer>()
                .materials[1]
                .mainTexture = viewConfig.View;
        }

        protected override void ExecuteOnEnter(CharacterMovement component)
        {
            FindObjectOfType<LevelData>()
                .CollectItem(_task);

            Instantiate(_destroyEffect, transform.position, identity, transform.parent);
            Destroy(gameObject);
        }
    }
}