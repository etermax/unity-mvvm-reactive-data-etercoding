using Commands;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class CharacterMotionInput : MonoBehaviour
    {
        public CharacterCmdFactory cmdFactory;
        public CharacterData characterData;
        
        public void OnClick(CharacterMotion motion)
        {
            cmdFactory.PerformMotion(characterData, motion).Execute();
        }
    }
}