using System;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Logic.Level
{
    public class ItemAssigner : MonoBehaviour
    {
        [SerializeField] private ItemConfig[] _config;
        
        private void Awake()
        {
            Array values = Enum.GetValues(typeof(ItemType));

            ItemType itemType = (ItemType)values.GetValue(Random.Range(0, values.Length));
            
            GetComponent<ItemTrigger>()
                .Install(_config.First(x => x.Type == itemType));
        }
    }
}