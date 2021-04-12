using Infrastructure;
using UnityEngine;
using ViewModel;

namespace Commands
{
    [CreateAssetMenu(fileName = "CharacterCmdFactory", menuName = "Command Factory/Character")]
    public class CharacterCmdFactory : ScriptableObject
    {
        public PerformMotionCmd PerformMotion(CharacterData characterData, CharacterMotion motion)
        {
            return new PerformMotionCmd(characterData, motion);
        }
        
        public PlayTurnCmd PlayTurn(CharacterData characterData)
        {
            return new PlayTurnCmd(characterData, new PlayTurnGateway(), new MetricsTagger());
        }
    }
}