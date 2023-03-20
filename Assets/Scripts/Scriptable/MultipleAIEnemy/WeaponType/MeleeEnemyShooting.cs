using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy/ MeleeEnemyShooting")]
    public class MeleeEnemyShooting : AbstractEnemyWeaponBase
    {
        

        float angleDegrees = 90;
        public override IEnumerator shootBetweenDelay(Transform shooting)
        {
            while (true)
            {
                Instantiate(VFX, shooting.position, shooting.localRotation * Quaternion.Euler(Vector3.forward * angleDegrees));
                Instantiate(VFX, shooting.position, shooting.localRotation * Quaternion.Euler(Vector3.forward * (angleDegrees + 180)));
                Instantiate(VFX, shooting.position, shooting.localRotation * Quaternion.Euler(Vector3.right * (angleDegrees + 90)));
                Instantiate(VFX, shooting.position, shooting.localRotation * Quaternion.Euler(Vector3.right * (angleDegrees - 90)));
                yield return new WaitForSeconds(attackdelay);
            }
        }



    }
}