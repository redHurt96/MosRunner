using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project.Logic.Level
{
    public class TestItemAssigner : MonoBehaviour
    {
        private void Awake()
        {
            Array values = Enum.GetValues(typeof(ItemType));
            
            GetComponent<ItemTrigger>()
                .Type = (ItemType)values.GetValue(Random.Range(0, values.Length));
        }
    }
}