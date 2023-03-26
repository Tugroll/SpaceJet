using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy / OctopusEnemyAIShoot")]
    public class OctopusEnemyShooting : AbstractEnemyWeaponBase
    {
        public override IEnumerator shootBetweenDelay(Transform shooting)
        {
            
            while (true)
            {
                for (int i = 0; i < 8; i++)
                {
                    GameObject Child = Instantiate(VFX, shooting.transform.position + new Vector3(Random.Range(-2, 2), Random.Range(-1, 1)), shooting.transform.rotation);

                }
                yield return new WaitForSeconds(attackDelay);
            }
        }

       
        
    }
}