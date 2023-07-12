using UnityEngine;

namespace _Project.Logic.Level
{
    [RequireComponent(typeof(Renderer))]
    public class InvisibleObjectsRenderer : MonoBehaviour
    {
        private void Awake() => 
            GetComponent<Renderer>().enabled = false;
    }
}