using UnityEngine;

namespace _Project.Logic.Level
{
    public class ItemAssigner : MonoBehaviour
    {
        [SerializeField] private Texture[] _textures;
        
        private void Awake()
        {
            ItemViewConfig config = FindObjectOfType<LevelData>()
                .GetRandomItemViewConfig();
            
            GetComponent<ItemTrigger>()
                .Install(config);
        }
    }
}