using System.Collections.Generic;
using _Project.Logic.Level;
using RH_Utilities.Attributes;
using UnityEngine;

namespace _Project.Logic
{
    public class LevelData : MonoBehaviour
    {
        public float TileSpeed;
        
        [SerializeField] private float _tileSpeedIncreaseDelta = 2f;

        [SerializeField, ReadOnly] private List<ItemType> _collectedItems = new();

        public void IncreaseTilesSpeed() => 
            TileSpeed += _tileSpeedIncreaseDelta;

        public void CollectItem(ItemType type)
        {
            if (!IsItemCollected(type))
                _collectedItems.Add(type);
        }

        public bool IsItemCollected(ItemType itemType) => 
            _collectedItems.Contains(itemType);
    }
}