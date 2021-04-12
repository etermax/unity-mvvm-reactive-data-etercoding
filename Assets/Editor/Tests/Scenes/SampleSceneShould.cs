using Components;
using Editor.Tests.Components;
using NUnit.Framework;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Editor.Tests.Scenes
{
    [TestFixture]
    public class SampleSceneShould
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity");
        }
        
        [Test]
        public void contain_character_name_display()
        {
            var component = Object.FindObjectOfType<CharacterNameDisplay>();
            
            Assert.NotNull(component);
            Assert.NotNull(component.nameLabel);
            Assert.NotNull(component.characterData);
        }

        [Test]
        public void contain_character_energy_display()
        {
            var component = Object.FindObjectOfType<CharacterEnergyDisplay>();
            
            Assert.NotNull(component);
            Assert.NotNull(component.energyLabel);
            Assert.NotNull(component.characterData);
        }

        [Test]
        public void contain_character_motion_input()
        {
            var component = Object.FindObjectOfType<CharacterMotionInput>();
            
            Assert.NotNull(component);
        }

        [Test]
        public void contain_character_animation_display()
        {
            var component = Object.FindObjectOfType<CharacterAnimationDisplay>();
            
            Assert.NotNull(component);
            Assert.NotNull(component.animator);
            
        }
    }
}