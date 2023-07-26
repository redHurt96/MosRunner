using RH_Utilities.Extensions;
using static UnityEngine.Input;
using static UnityEngine.Time;
using UnityEngine;
using static UnityEngine.KeyCode;

namespace _Project.Logic.Common
{
    public static class ProjectInputService
    {
        private const string HORIZONTAL_AXIS = "Horizontal";
        private const string VERTICAL_AXIS = "Vertical";
        private const float AXIS_THRESHOLD = .9f;
        private const float PRESS_DELAY = .3f;

        public static bool LeftButtonPressed
        {
            get
            {
                if (time.ApproximatelyEqual(_lastLeftPressedTime) && _lastLeftPressedTime > 0f)
                    return true;
                
                if (time - _lastLeftPressedTime < PRESS_DELAY)
                    return false;

                bool buttonPressed = GetAxis(HORIZONTAL_AXIS) < -AXIS_THRESHOLD || GetKeyDown(A);

                if (buttonPressed)
                    _lastLeftPressedTime = time;

                return buttonPressed;
            }
        }

        public static bool RightButtonPressed
        {
            get
            {
                if (time.ApproximatelyEqual(_lastRightPressedTime) && _lastRightPressedTime > 0f)
                    return true;
                
                if (time - _lastRightPressedTime < PRESS_DELAY)
                    return false;

                bool buttonPressed = GetAxis(HORIZONTAL_AXIS) > AXIS_THRESHOLD || GetKeyDown(D);

                if (buttonPressed)
                    _lastRightPressedTime = time;

                return buttonPressed;
            }
        }

        public static bool UpButtonPressed
        {
            get
            {
                if (time.ApproximatelyEqual(_lastUpPressedTime) && _lastUpPressedTime > 0f)
                    return true;
                
                if (time - _lastUpPressedTime < PRESS_DELAY)
                    return false;

                bool buttonPressed = GetAxis(VERTICAL_AXIS) < -AXIS_THRESHOLD || GetKeyDown(KeyCode.Space);

                if (buttonPressed)
                    _lastUpPressedTime = time;

                return buttonPressed;
            }
        }

        private static float _lastUpPressedTime = 0f;
        private static float _lastLeftPressedTime = 0f;
        private static float _lastRightPressedTime = 0f;
    }
}