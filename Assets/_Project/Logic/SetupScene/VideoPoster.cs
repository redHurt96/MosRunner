using _Project.Logic.Common;
using UnityEngine;
using UnityEngine.Video;

namespace _Project.Logic.SetupScene
{
    public class VideoPoster : MonoBehaviour
    {
        [SerializeField] private GameObject _tutorialTip;
        [SerializeField] private GameObject _next;
        [SerializeField] private VideoPlayer _videoPlayer;

        private void Start()
        {
            _tutorialTip.SetActive(false);
            _videoPlayer.loopPointReached += EnableButton;
        }

        private void OnDestroy() => 
            _videoPlayer.loopPointReached -= EnableButton;

        private void Update()
        {
            if (ProjectInputService.UpButtonPressed && !_videoPlayer.isPlaying)
                Interact();
        }

        public void Interact()
        {
            _next.SetActive(true);
            gameObject.SetActive(false);
        }

        private void EnableButton(VideoPlayer source) => 
            _tutorialTip.SetActive(true);
    }
}