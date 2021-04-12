using Commands;
using NUnit.Framework;
using UnityEngine;
using ViewModel;

namespace Editor.Tests.Commands
{
    [TestFixture]
    public class PerformMotionCmdShould
    {
        [Test]
        public void reduce_character_energy()
        {
            var initialEnergy = 100;
            var jumpEnergyCost = 8;
            var characterData = ScriptableObject.CreateInstance<CharacterData>();
            var characterMotion = ScriptableObject.CreateInstance<CharacterMotion>();
            characterMotion.energyCost = jumpEnergyCost;
            characterData.energy.Value = initialEnergy;
            
            var cmd = new PerformMotionCmd(characterData, characterMotion);
            cmd.Execute();
            
            Assert.AreEqual(initialEnergy - jumpEnergyCost, characterData.energy.Value);
        }
    }
}