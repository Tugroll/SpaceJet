using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.PlayerInput
{
    public abstract class AbstractInputData : ScriptableObject 
    {
        public float Horizontal;
        public float Vertical;
        public KeyCode Shoot;
        public KeyCode swapWeapon;
       
        public abstract void ProcessInput(Weapon.Weapon weapon);



    }
}