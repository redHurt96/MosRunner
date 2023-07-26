using _Project.Logic.Level;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    [RequireComponent(typeof(Text))]
    public class CategoryPercentUIView : MonoBehaviour
    {
        [SerializeField] private Category _category;
        
        private Text _label;

        private void Awake() => 
            _label = GetComponent<Text>();

        private void OnEnable() =>
            _label.text = FindObjectOfType<LevelData>()
                              .GetPercent(_category)
                              .ToString("F0")
                          + "%";
    }
}