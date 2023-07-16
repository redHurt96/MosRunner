using System;
using _Project.Logic.Character;
using RH_Utilities.Level;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class ItemTrigger : ComponentTrigger<CharacterMovement>
    {
        public ItemType Type
        {
            set => _type = value;
        }
        
        [SerializeField] private ItemType _type;
        
        protected override void ExecuteOnEnter(CharacterMovement component)
        {
            FindObjectOfType<LevelData>()
                .CollectItem(_type);
            
            Destroy(gameObject);
        }
    }
}