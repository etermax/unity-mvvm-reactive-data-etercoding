using System;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class CharacterAnimationDisplay : MonoBehaviour
    {
        public Animator animator;
        public CharacterData characterData;

        public void Start()
        {
            characterData.onMotion
                .Subscribe(AnimateMotion)
                .AddTo(this);
        }

        private void AnimateMotion(CharacterMotion motion)
        {
            animator.SetTrigger(motion.name);
        }
    }
}