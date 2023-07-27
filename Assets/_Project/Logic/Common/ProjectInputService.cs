using static UnityEngine.Input;
using static UnityEngine.KeyCode;

namespace _Project.Logic.Common
{
    public static class ProjectInputService
    {
        private static bool _disabled;
        public static bool LeftButtonPressed => GetKeyDown(LeftArrow) && !_disabled;
        public static bool RightButtonPressed => GetKeyDown(RightArrow) && !_disabled;
        public static bool UpButtonPressed => GetKeyDown(UpArrow) && !_disabled;

        public static void Disable() => 
            _disabled = true;

        public static void Enable() => 
            _disabled = false;
    }
}