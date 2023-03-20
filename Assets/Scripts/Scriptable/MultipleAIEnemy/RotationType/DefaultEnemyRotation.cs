using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy/ DefaultEnemyRotation")]
    public class DefaultEnemyRotation : AbstractEnemyRotationBase
    {
        public override void Rotate(float rotationSpeed, Transform target, Transform from)
        {
            Vector3 desiredDirection = target.transform.position - from.position;
            float desiredAngle = Mathf.Atan2(desiredDirection.y, desiredDirection.x) * Mathf.Rad2Deg - 90;
            from.rotation = Quaternion.AngleAxis(desiredAngle, Vector3.forward);
        }

        
    }
}