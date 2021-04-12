using Commands;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class PlayTurnInput : MonoBehaviour
    {
        public CharacterCmdFactory cmdFactory;
        public CharacterData characterData;

        public void OnClick()
        {
            cmdFactory.PlayTurn(characterData).Execute();
        }
    }
}