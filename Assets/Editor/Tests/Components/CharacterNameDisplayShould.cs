using Components;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using ViewModel;

namespace Editor.Tests.Components
{
    [TestFixture]
    public class CharacterNameDisplayShould
    {
        private TextMeshProUGUI _textField;
        private GameObject _gameObject;

        [SetUp]
        public void SetUp()
        {
            _gameObject = new GameObject();
            _textField = _gameObject.AddComponent<TextMeshProUGUI>();
            _textField.text = "";
        }

        [Test]
        public void show_character_name()
        {
            var component = _gameObject.AddComponent<CharacterNameDisplay>();
            component.nameLabel = _textField;
            component.characterData = ScriptableObject.CreateInstance<CharacterData>();

            component.Start();
            component.characterData.characterName.Value = "Pepe";

            Assert.AreEqual("Pepe", _textField.text);
        }
    }
}