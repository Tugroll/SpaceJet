using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Weapon
{
    [CreateAssetMenu(menuName = "SpaceJet/Weapon/ Attack")]
    public class DefaultAttack : AttackPatternSO
    {
        public GameObject projectile;
        public override void Perform(Transform shootingStartPoint)
        {
            Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
        }
    }
}