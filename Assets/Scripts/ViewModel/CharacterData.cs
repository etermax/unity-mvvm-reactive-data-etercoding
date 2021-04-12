using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "Character", menuName = "Data/Character")]
    public class CharacterData : ScriptableObject
    {
        public StringReactiveProperty characterName = new StringReactiveProperty();
        public IntReactiveProperty energy = new IntReactiveProperty(100);
        public ISubject<CharacterMotion> onMotion = new Subject<CharacterMotion>();
    }
}