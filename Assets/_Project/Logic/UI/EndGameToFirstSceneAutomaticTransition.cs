using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Logic.UI
{
    public class EndGameToFirstSceneAutomaticTransition : MonoBehaviour
    {
        [SerializeField] private float _time = 60f;
        
        private IEnumerator Start()
        {
            yield return new WaitForSeconds(_time);

            SceneManager.LoadScene(0);
        }
        
    }
}