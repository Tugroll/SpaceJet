using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Weapon
{
    [CreateAssetMenu(menuName = "SpaceJet/Weapon/DoubleAttack")]
    public class DoubleAttack : AttackPatternSO
    {
        public GameObject projectile;
        public float offsetFromStartPoint = .4f;
        public override void Perform(Transform shootingStartPoint)
        {
            Vector3 offset = shootingStartPoint.rotation * new Vector3(offsetFromStartPoint, 0, 0);

            Vector3 point1 = shootingStartPoint.position + offset;
            Vector3 point2 = shootingStartPoint.position - offset;

            Instantiate(projectile, point1, shootingStartPoint.rotation);
            Instantiate(projectile, point2, shootingStartPoint.rotation);
        }
    }
}