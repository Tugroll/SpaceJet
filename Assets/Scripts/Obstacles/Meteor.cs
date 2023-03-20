using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Enemy
{
    public class Meteor : MonoBehaviour
    {
        Rigidbody2D rb;
        float rotationSpeed = 1;
        float speed = 2;
        Vector2 direction = Vector2.down;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            transform.Rotate(0, 0, rotationSpeed );
        }
        private void FixedUpdate()
        {
            rb.velocity = direction * speed;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            IHittable hittable = collision.GetComponent<IHittable>();
            if(hittable != null)
            {
                hittable.GetHit(1, gameObject);
                GetHit(collision.gameObject);
            }
        }
        public void GetHit(GameObject Sender)
        {
            Vector2 NewDirection = transform.position - Sender.transform.position;
            direction = NewDirection.normalized;
            
        }
    }
}