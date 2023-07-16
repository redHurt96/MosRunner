using UnityEngine;
using static _Project.Logic.SetupScene.CharacterData;

namespace _Project.Logic.SetupScene
{
    public class CharacterSkinApplier : MonoBehaviour
    {
        [SerializeField] private GameObject _man;
        [SerializeField] private GameObject _woman;

        private void Awake()
        {
            _man.SetActive(IsMale);
            _woman.SetActive(!IsMale);
        }
    }
}