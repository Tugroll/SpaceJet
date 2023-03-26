using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Weapon
{
    [CreateAssetMenu(menuName = "SpaceJet/Weapon/ SpreadAttack")]
    public class SpreadAttack : AttackPatternSO
    {
        public GameObject projectile;

        public float angleDegrees = 5;
        public override void Perform(Transform shootingStartPoint)
        {
            projectile.GetComponent<SpriteRenderer>().sprite = _sprite;
            Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
            Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation * Quaternion.Euler(Vector3.forward * angleDegrees));
            Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation * Quaternion.Euler(Vector3.forward * -angleDegrees));
        }
    }
}