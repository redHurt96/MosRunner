using _Project.Logic.Character;
using RH_Utilities.Level;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class ItemTrigger : ComponentTrigger<CharacterMovement>
    {
        [SerializeField] private int _type;

        public void Install(ItemConfig config)
        {
            _type = config.Index;
            GetComponentInChildren<MeshRenderer>()
                .materials[1]
                .mainTexture = config.View;
        }

        protected override void ExecuteOnEnter(CharacterMovement component)
        {
            FindObjectOfType<LevelData>()
                .CollectItem(_type);
            
            Destroy(gameObject);
        }
    }
}