
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    public class EnemyShooting : MonoBehaviour
    {
        [SerializeField] AbstractEnemyWeaponBase enemyShootType;
        void Start()
        {
            StartCoroutine(enemyShootType.shootBetweenDelay(this.transform));
        }

        
    }
}