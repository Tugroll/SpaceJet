using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    [CreateAssetMenu(menuName = "SpaceJet/ Enemy/ OctopusEnemyMove")]
    public class OctopusEnemyMovementType : AbstractEnemyMovementType
    {
        bool detected = false;
        public override void Move(Rigidbody2D rb)
        {

            Transform Target = FindObjectOfType<PlayerDeathUI>().transform;
            Vector3 desiredDirection = Target.transform.position - rb.transform.position;
            desiredDirection.Normalize();
            float desiredAngle = Mathf.Atan2(desiredDirection.y, desiredDirection.x) * Mathf.Rad2Deg - 90;
            rb.transform.rotation = Quaternion.AngleAxis(desiredAngle, Vector3.forward);



            if (Vector3.Distance(rb.transform.position, Target.position) < 7)
            {
                rb.velocity = desiredDirection * -speed;
            }
            else if (Vector3.Distance(rb.transform.position, Target.position) > 10)
            {
                rb.velocity = desiredDirection * speed;
            }
            else
                rb.velocity = rb.transform.right * speed;


        }


    }
}