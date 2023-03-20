using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy / DefaultEnemyAIShoot")]
    public class DefaultEnemyShooting : AbstractEnemyWeaponBase
    {
        public override IEnumerator shootBetweenDelay(Transform shooting)
        {
            while (true)
            {
                yield return new WaitForSeconds(attackdelay);
                GameObject p = Instantiate(VFX, shooting.position, shooting.rotation);
            }
        }
    }
}