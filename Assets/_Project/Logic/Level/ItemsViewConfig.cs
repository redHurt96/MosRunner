using RH_Utilities.Extensions;
using UnityEngine;

namespace _Project.Logic.Level
{
    [CreateAssetMenu(menuName = "Create ItemsViewConfig", fileName = "ItemsViewConfig", order = 0)]
    public class ItemsViewConfig : ScriptableObject
    {
        [SerializeField] private ItemViewConfig[] _configs;
        
        public ItemViewConfig GetRandom() => 
            _configs.GetRandom();
    }
}