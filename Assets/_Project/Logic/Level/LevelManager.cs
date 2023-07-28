using System;
using UnityEngine;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.Level
{
    public class LevelManager : MonoBehaviour
    {
        public bool GameEnded = false;
        
        public event Action OnEnd;
        
        private LevelData _data;

        public void EndGame()
        {
            if (GameEnded)
                return;
            
            _data ??= FindObjectOfType<LevelData>();
            _data.TileSpeed = 0f;

            Show("end_game");
            GameEnded = true;
            OnEnd?.Invoke();
        }
    }
}