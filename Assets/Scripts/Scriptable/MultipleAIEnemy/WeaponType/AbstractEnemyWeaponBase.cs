using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    public abstract class AbstractEnemyWeaponBase : ScriptableObject
    {
        [SerializeField]
        protected float attackDelay = 0.2f;
        public float attackdelay => attackDelay;


        public GameObject VFX;

        [SerializeField]
        protected AudioClip weaponSFX;
        public AudioClip _weaponSFX => weaponSFX;

        public abstract IEnumerator shootBetweenDelay(Transform shooting);

    }
}