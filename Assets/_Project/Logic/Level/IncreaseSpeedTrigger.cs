using _Project.Logic.Character;
using RH_Utilities.Level;

namespace _Project.Logic.Level
{
    public class IncreaseSpeedTrigger : ComponentTrigger<CharacterMovement>
    {
        protected override void ExecuteOnEnter(CharacterMovement component) =>
            FindObjectOfType<LevelData>()
                .IncreaseTilesSpeed();
    }
}