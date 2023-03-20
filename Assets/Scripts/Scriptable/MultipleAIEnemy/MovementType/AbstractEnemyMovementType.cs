using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    public abstract class AbstractEnemyMovementType : ScriptableObject
    {
        [SerializeField]
        protected float speed;
        public float _speed => speed;


        public abstract void Move(Rigidbody2D rb);
    }
}