using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    public abstract class AbstractEnemyRotationBase : ScriptableObject
    {
        [SerializeField] private float rotationSpeed;
        public float _rotationSpeed => rotationSpeed;


        public abstract void Rotate(float rotationSpeed,Transform target, Transform from);
    }
}