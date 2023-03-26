using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using SpaceJet.Observe;

public class EnemySpawner : AbstractSubject
    {
        public BoxCollider2D boxCollider;
        public int waveCount = 5;
        public InGameMenu winScreen;



        [SerializeField] EnemySpawnerBase enemySpawner;
        [SerializeField] EnemySpawnerBase obstaclesSpawner;
        void Start()
        {
            AddObserver(FindObjectOfType<UIObserver>());

            StartCoroutine(enemySpawner.SpawnWithDelay(boxCollider, this.transform, this));
            StartCoroutine(obstaclesSpawner.SpawnWithDelay(boxCollider, this.transform, this));

        }

        public void EnemyKilled(Enemy enemy, bool playerKill)
        {
            enemySpawner.currentEnemy.Remove(enemy.gameObject);
            if (playerKill)
            {
                OnNotify(ActionData.score);

            }
            if (enemySpawner.currentWave >= waveCount && enemySpawner.currentEnemy.Count == 0)
            {
                OnNotify(ActionData.score);
                winScreen.Toggle();
                return;
            }

        }
    }
