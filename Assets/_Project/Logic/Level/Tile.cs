using UnityEngine;
using static UnityEngine.Time;
using static UnityEngine.Vector3;

namespace _Project.Logic.Level
{
    public class Tile : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        
        private LevelData _levelData;

        private void Start() => 
            _levelData = FindObjectOfType<LevelData>();

        private void Update() =>
            _rigidbody.MovePosition(transform.position + forward * (_levelData.TileSpeed * deltaTime));
    }
}