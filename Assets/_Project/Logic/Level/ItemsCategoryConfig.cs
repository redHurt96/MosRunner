using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Project.Logic.Level
{
    [CreateAssetMenu(menuName = "Create ItemsCategoryConfig", fileName = "ItemsCategoryConfig", order = 0)]
    public class ItemsCategoryConfig : ScriptableObject
    {
        [SerializeField] private List<ItemCategoryConfig> _configs = new();

        private Dictionary<Category, string[]> _configsDictionary;

        private void Init() =>
            _configsDictionary = _configs
                .ToDictionary(x => x.Category, y => y.Tasks);

        public bool Contains(string task, Category category)
        {
            if (_configsDictionary == null)
                Init();
            
            return _configsDictionary[category]
                .Any(x => x == task);
        }

        public float TasksCount(Category forCategory)
        {
            if (_configsDictionary == null)
                Init();
            
            return _configsDictionary[forCategory].Length;
        }
    }
}