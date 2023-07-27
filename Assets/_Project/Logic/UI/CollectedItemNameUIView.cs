using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class CollectedItemNameUIView : MonoBehaviour
    {
        [SerializeField] private Color _in;
        [SerializeField] private Color _out;
        
        private Text _text;

        private void Start()
        {
            _text ??= GetComponent<Text>();

            _text
                .DOColor(_in, 1f)
                .OnComplete(() =>
                    _text.DOColor(_out, .95f));
            
            transform
                .DOLocalMoveY(350, 2f)
                .OnComplete(() => Destroy(gameObject));
        }

        public void Setup(string task)
        {
            _text ??= GetComponent<Text>();
            _text.text = task;
        }
    }
}