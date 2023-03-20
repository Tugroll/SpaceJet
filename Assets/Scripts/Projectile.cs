using SpaceJet.Enemy;
using SpaceJet.Stats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb2d;
    public float deathDelay = 5;

    public bool disabled = false;

    [SerializeField] private Health _health;
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = transform.up * speed;
        _health.InitializeHealth(1);
        StartCoroutine(DeathAfterDelay(deathDelay));
    }

    private IEnumerator DeathAfterDelay(float deathDelay)
    {
       
        yield return new WaitForSeconds(deathDelay);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IHittable hittable = collision.GetComponent<IHittable>();
        if(hittable != null)
        {
            
            hittable.GetHit(1, gameObject);
            _health.GetHit(1, gameObject);
            Destroy(gameObject);
        } 
       
    }

    
}
