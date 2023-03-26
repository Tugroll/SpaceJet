
using SpaceJet.Observe;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Weapon
{
    public class Weapon : AbstractSubject
    {
        [SerializeField] private AttackPatternSO attackPattern;
       
        
        public Transform shootingStartPoint;
        public bool shootingDelayed;


        [SerializeField]
        List<AttackPatternSO> attackList = new List<AttackPatternSO>();
        private int index = 0;

        private void OnEnable()
        {
            AddObserver(FindObjectOfType<UIObserver>());
        }
        public void SwapWeapon()
        {
            index++;
            index = index >= attackList.Count ? 0 : index;
            
            attackPattern = attackList[index];
            OnNotify(ActionData.swapweapon);
        }
        public void PerformAttack()
        {
            if (shootingDelayed == false)
            {
                shootingDelayed = true;
                

                attackPattern.Perform(shootingStartPoint);

                StartCoroutine(DelayShooting());
            }
        }
        private IEnumerator DelayShooting()
        {
            yield return new WaitForSeconds(attackPattern.attackdelay);
            shootingDelayed = false;
        }
    }
}