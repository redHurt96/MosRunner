using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class CollectedItemNameUIView : MonoBehaviour
    {
        public event Action<float> TextAssigned;
        
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private Text _text;

        private void Start()
        {
            _canvasGroup
                .DOFade(1f, 1f)
                .OnComplete(() =>
                    _canvasGroup.DOFade(0f, .95f));
            
            transform
                .DOLocalMoveY(350, 2f)
                .OnComplete(() => Destroy(gameObject));
        }

        public void Setup(string task)
        {
            _text.text = task;
            TextAssigned?.Invoke(_text.preferredWidth);
        }
    }
}