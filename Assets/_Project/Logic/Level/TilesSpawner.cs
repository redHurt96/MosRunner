using UnityEngine;

namespace _Project.Logic.Level
{
    public class TilesSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _origin;
        [SerializeField] private float _lenght;
        
        public void Execute(Vector3 parentPosition) => 
            Instantiate(_origin, parentPosition + Vector3.back * _lenght, Quaternion.identity);

        public void Remove(GameObject tile) => 
            Destroy(tile);
    }
}