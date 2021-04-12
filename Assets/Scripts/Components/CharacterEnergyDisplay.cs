using System;
using TMPro;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class CharacterEnergyDisplay : MonoBehaviour
    {
        public TextMeshProUGUI energyLabel;
        public CharacterData characterData;

        public void Start()
        {
            characterData.energy
                .Subscribe(UpdateEnergy)
                .AddTo(this);
        }

        private void UpdateEnergy(int energy)
        {
            energyLabel.text = energy.ToString();
        }
    }
}