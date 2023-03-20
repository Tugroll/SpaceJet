using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy/MeleeRotation")]
    public class MeleeEnemyRotation : AbstractEnemyRotationBase
    {
        public override void Rotate(float rotationSpeed, Transform target, Transform from)
        {
            from.Rotate(0, 0, rotationSpeed);
        }
    }
}