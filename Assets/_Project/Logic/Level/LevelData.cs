using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class LevelData : MonoBehaviour
    {
        public float TileSpeed;

        [SerializeField] private ItemsCategoryConfig _itemsCategoryConfig;
        [SerializeField] private ItemsViewConfig _itemsViewConfig;
         
        [SerializeField] private float _tileSpeedIncreaseDelta = 2f;
        [SerializeField] private List<string> _collectedItems = new();

        public void IncreaseTilesSpeed() => 
            TileSpeed += _tileSpeedIncreaseDelta;

        public void CollectItem(string type)
        {
            if (!IsItemCollected(type))
                _collectedItems.Add(type);
        }

        public float GetPercent(Category category) =>
            _collectedItems.Count(x => _itemsCategoryConfig.Contains(x, category)) 
            / _itemsCategoryConfig.TasksCount(category) 
            * 100;

        private bool IsItemCollected(string itemType) => 
            _collectedItems.Contains(itemType);

        public ItemViewConfig GetRandomItemViewConfig() => 
            _itemsViewConfig.GetRandom();
    }
}