using _Project.Logic.Character;
using RH_Utilities.Level;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class ItemTrigger : ComponentTrigger<CharacterMovement>
    {
        [SerializeField] private ItemType _type;

        public void Install(ItemConfig config)
        {
            _type = config.Type;
            Instantiate(config.View, transform);
        }

        protected override void ExecuteOnEnter(CharacterMovement component)
        {
            FindObjectOfType<LevelData>()
                .CollectItem(_type);
            
            Destroy(gameObject);
        }
    }
}