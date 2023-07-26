using _Project.Logic.Level;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class TaskPanel : MonoBehaviour
    {
        [SerializeField] private Text _checkMark;
        [SerializeField] private int _itemType;

        private void OnEnable() =>
            _checkMark.text = FindObjectOfType<LevelData>().IsItemCollected(_itemType)
                ? "+"
                : "-";
    }
}