using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "CharacterMotion", menuName = "Data/Character Motion")]
    public class CharacterMotion : ScriptableObject
    {
        public int energyCost;
    }
}