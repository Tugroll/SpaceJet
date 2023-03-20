using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceJet.Player;

namespace SpaceJet.Enemy
{
    public class EnemyRotationController : MonoBehaviour
    {
        [SerializeField] private AbstractEnemyRotationBase enemyRotationType;
        private PlayerMovementController target;

        private void Start()
        {
            target = FindObjectOfType<PlayerMovementController>();
        }
        void Update()
        {
            if (target != null)
            {
                enemyRotationType.Rotate(enemyRotationType._rotationSpeed,target.transform,this.transform);
            }
            else
            {
                transform.rotation = transform.rotation;
            }
        }
    }
}