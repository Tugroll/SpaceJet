using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Weapon
{
    
    public abstract class AttackPatternSO : ScriptableObject
    {
        [SerializeField]
        protected float attackDelay = 0.2f;
        public float attackdelay => attackDelay;

        [SerializeField]
        protected AudioClip weaponSFX;

        public AudioClip _weaponSFX => weaponSFX;

        public abstract void Perform(Transform shootingStartPoint);
    }
}