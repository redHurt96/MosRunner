using System.Collections.Generic;
using System.Linq;
using RH_Utilities.Extensions;
using UnityEngine;

namespace _Project.Logic.Level
{
    public class ObjectsLoader : MonoBehaviour
    {
        [SerializeField] private Transform[] _anchors;
        [SerializeField] private GameObject[] _obstacles;
        [SerializeField] private int _obstaclesCount;
        [SerializeField] private Transform _obstaclesParent;

        private void Start()
        {
            List<Transform> anchors = _anchors.ToList();

            for (int i = 0; i < _obstaclesCount; i++)
            {
                Transform anchor = anchors.GetRandom();
                anchors.Remove(anchor);
                Instantiate(_obstacles.GetRandom(), anchor.position, anchor.rotation, _obstaclesParent);
            }
        }
    }
}