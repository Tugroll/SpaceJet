using SpaceJet.AI;
using SpaceJet.Stats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private int startingHealth = 3;

    public EnemySpawner enemySpawner;

    [SerializeField] Health _health;


    private void Awake()
    {
        _health.InitializeHealth(startingHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        IHittable hittable = collision.GetComponent<IHittable>();

        if (hittable != null)
        {
            hittable.GetHit(1, gameObject);

        }

    }



    public void EnemyKilledOutsideBounds()
    {
        enemySpawner.EnemyKilled(this, false);
        Destroy(gameObject);
    }



    public void Death()
    {
        enemySpawner.EnemyKilled(this, true);

        StopAllCoroutines();
        Destroy(gameObject);


    }
}
