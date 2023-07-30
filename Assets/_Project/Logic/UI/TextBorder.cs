using UnityEngine;

namespace _Project.Logic.UI
{
    public class TextBorder : MonoBehaviour
    {
        [SerializeField] private CollectedItemNameUIView _itemName;
        [SerializeField] private RectTransform _rect;

        private void Awake() => 
            _itemName.TextAssigned += Adjust;

        private void OnDestroy() => 
            _itemName.TextAssigned -= Adjust;

        private void Adjust(float width) => 
            _rect.sizeDelta = new(width + 200, _rect.sizeDelta.y);
    }
}