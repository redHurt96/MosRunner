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

        [SerializeField, ReadOnly] private List<int> _collectedItems = new();

        public void IncreaseTilesSpeed() => 
            TileSpeed += _tileSpeedIncreaseDelta;

        public void CollectItem(int type)
        {
            if (!IsItemCollected(type))
                _collectedItems.Add(type);
        }

        public bool IsItemCollected(int itemType) => 
            _collectedItems.Contains(itemType);
    }
}