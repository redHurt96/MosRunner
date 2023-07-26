using System;
using System.Linq;
using UnityEngine;
using RH_Utilities.Extensions;

namespace _Project.Logic.Level
{
    public class ItemAssigner : MonoBehaviour
    {
        [SerializeField] private Texture[] _textures;
        
        private void Awake()
        {
            int index = UnityEngine.Random.Range(0, _textures.Length);

            GetComponent<ItemTrigger>()
                .Install(new()
                {
                    Index = index,
                    View = _textures[index],
                });
        }
    }
}