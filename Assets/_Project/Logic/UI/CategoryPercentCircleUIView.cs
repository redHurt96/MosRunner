using _Project.Logic.Level;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    [RequireComponent(typeof(Image))]
    public class CategoryPercentCircleUIView : MonoBehaviour
    {
        [SerializeField] private Category _category;
        
        private Image _circle;

        private void Awake() => 
            _circle = GetComponent<Image>();

        private void OnEnable() =>
            _circle.fillAmount = FindObjectOfType<LevelData>()
                .GetPercent(_category);
    }
}