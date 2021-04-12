using ViewModel;

namespace Commands
{
    public class PerformMotionCmd : ICommand
    {
        private readonly CharacterData _characterData;
        private readonly CharacterMotion _motion;

        public PerformMotionCmd(CharacterData characterData, CharacterMotion motion)
        {
            _characterData = characterData;
            _motion = motion;
        }

        public void Execute()
        {
            _characterData.energy.Value -= _motion.energyCost;
            _characterData.onMotion.OnNext(_motion);
        }
    }
}