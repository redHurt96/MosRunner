using System;
using UnityEngine;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.Level
{
    public class LevelManager : MonoBehaviour
    {
        public event Action OnEnd;
        
        private LevelData _data;

        public void EndGame()
        {
            _data ??= FindObjectOfType<LevelData>();
            _data.TileSpeed = 0f;
            
            Show("end_game");
            
            OnEnd?.Invoke();
        }
    }
}