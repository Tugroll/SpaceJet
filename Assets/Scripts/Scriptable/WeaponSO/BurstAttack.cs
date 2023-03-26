using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Weapon
{
    [CreateAssetMenu(menuName = "SpaceJet/Weapon/ BurstAttack")]
    public class BurstAttack : AttackPatternSO
    {
        public GameObject projectile;
        public float offset = .1f;

        public override void Perform(Transform shootingStartPoint)
        {
            projectile.GetComponent<SpriteRenderer>().sprite = _sprite;
            Vector3 offsetDirection = shootingStartPoint.rotation * new Vector3(0, offset, 0);
            Instantiate(projectile, shootingStartPoint.position, shootingStartPoint.rotation);
            Instantiate(projectile, shootingStartPoint.position + offsetDirection, shootingStartPoint.rotation);
            Instantiate(projectile, shootingStartPoint.position - offsetDirection, shootingStartPoint.rotation);

        }


    }
}