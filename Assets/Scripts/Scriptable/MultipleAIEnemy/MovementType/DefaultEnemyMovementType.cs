using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy/ DefaultEnemyMove")]
    public class DefaultEnemyMovementType : AbstractEnemyMovementType
    {
        public override void Move(Rigidbody2D rb)
        {
            rb.MovePosition(rb.position + Vector2.down * speed * Time.deltaTime);
        }

        
    }
}