using static UnityEngine.Input;
using static UnityEngine.Time;
using UnityEngine;

namespace _Project.Logic.Common
{
    public static class ProjectInputService
    {
        private const string HORIZONTAL_AXIS = "Horizontal";
        private const string VERTICAL_AXIS = "Vertical";
        private const float AXIS_THRESHOLD = .9f;
        private const float PRESS_DELAY = .3f;

        public static bool LeftButtonPressed => GetAxis(HORIZONTAL_AXIS) < -AXIS_THRESHOLD || GetKeyDown(KeyCode.A);
        public static bool RightButtonPressed => GetAxis(HORIZONTAL_AXIS) > AXIS_THRESHOLD || GetKeyDown(KeyCode.D);
        public static bool UpButtonPressed
        {
            get
            {
                if (time - _lastUpPressedTime < PRESS_DELAY)
                    return false;
                
                bool upButtonPressed = GetAxis(VERTICAL_AXIS) < -AXIS_THRESHOLD || GetKeyDown(KeyCode.Space);

                if (upButtonPressed)
                    _lastUpPressedTime = time;
                    
                return upButtonPressed;
            }
        }

        private static float _lastUpPressedTime = 0f;
    }
}
