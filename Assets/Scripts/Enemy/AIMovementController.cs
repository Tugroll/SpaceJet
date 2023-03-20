using SpaceJet.Enemy;
using SpaceJet.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.AI
{
    public class AIMovementController : MonoBehaviour
    {
        [SerializeField] AbstractEnemyMovementType _aiMovementData;
        Rigidbody2D rb;
        void Awake()
        {
           
            rb = GetComponent<Rigidbody2D>();
            
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            _aiMovementData.Move(rb);
        }
    }
}