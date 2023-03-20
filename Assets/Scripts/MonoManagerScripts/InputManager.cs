using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] AbstractInputData InputData;
        [SerializeField] Weapon.Weapon weapon;
        void Update()
        {
            InputData.ProcessInput(weapon);
        }
    }
}