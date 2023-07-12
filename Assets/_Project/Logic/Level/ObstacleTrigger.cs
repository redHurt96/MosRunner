using RH_Utilities.Level;

namespace _Project.Logic.Level
{
    public class ObstacleTrigger : ComponentTrigger<CharacterMovement>
    {
        protected override void ExecuteOnEnter(CharacterMovement component) =>
            FindObjectOfType<LevelManager>()
                .EndGame();
    }
}