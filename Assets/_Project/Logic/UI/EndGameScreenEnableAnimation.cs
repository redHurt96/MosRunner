using System.Collections;
using DG.Tweening;
using UnityEngine;
using static UnityEngine.Vector3;

namespace _Project.Logic.UI
{
    public class EndGameScreenEnableAnimation : MonoBehaviour
    {
        private IEnumerator Start()
        {
            yield return new WaitForSeconds(1f);
            
            transform.DOScale(one, 1f);
        }
    }
}