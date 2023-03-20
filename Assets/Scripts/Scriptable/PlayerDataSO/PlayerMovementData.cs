using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Player
{
    [CreateAssetMenu(menuName = "SpaceJet/ PlayerUI/ MovementData")]
    public class PlayerMovementData : ScriptableObject
    {
        public float HorizontalMovementSpeed = 10;
        public float VerticalMovementSpeed = 15;
        


    }
}