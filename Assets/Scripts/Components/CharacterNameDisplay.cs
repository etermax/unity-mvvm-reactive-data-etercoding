using System;
using TMPro;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class CharacterNameDisplay : MonoBehaviour
    {
        public TextMeshProUGUI nameLabel;
        public CharacterData characterData;

        public void Start()
        {
            characterData.characterName
                .Subscribe(UpdateName)
                .AddTo(this);
        }

        private void UpdateName(string characterName)
        {
            nameLabel.text = characterName;
        }
    }
}