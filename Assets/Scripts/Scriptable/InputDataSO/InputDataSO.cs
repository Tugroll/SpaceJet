using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceJet.Weapon;
namespace SpaceJet.PlayerInput
{
    [CreateAssetMenu(menuName = "SpaceJet/ PlayerUI/ inputData")]
    public class InputDataSO : AbstractInputData 
    {
        [SerializeField] string axisNameHorizontal;
        [SerializeField] string axisNameVertical;
      
        public override void ProcessInput(Weapon.Weapon weapon)
        {
            Horizontal = Input.GetAxis(axisNameHorizontal);
            Vertical = Input.GetAxis(axisNameVertical);
           
            if (Input.GetKey(Shoot))
            {
                weapon.PerformAttack();
            }
            if (Input.GetKey(swapWeapon))
            {
                weapon.SwapWeapon();
            }



        }
    }
}