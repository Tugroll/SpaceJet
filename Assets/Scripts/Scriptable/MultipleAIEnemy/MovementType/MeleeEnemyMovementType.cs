using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy/ MeleeEnemyMove")]
    public class MeleeEnemyMovementType : AbstractEnemyMovementType
    {
        public float frequency = 2, amplitude = 1;

        public override void Move(Rigidbody2D rb)
        {
            //float cosVal = Mathf.Cos(Time.time * frequency) * amplitude;
            //rb.MovePosition(rb.position + new Vector2(cosVal,-1) * speed * Time.deltaTime);


            Vector2 pos = rb.position;
            float sinVal = Mathf.Sin(pos.y * frequency) * amplitude;
            Vector2 direction = Vector2.right * sinVal + Vector2.down;
            rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
        }
    }
}