using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySpawnerBase : ScriptableObject
{
    public float timeMin = 0.1f, timeMax = 0.3f;
    public int maxEnemies = 4;
    public float startDelay = 1;
    public int currentWave;
   
    public List<GameObject> currentEnemy = new List<GameObject>();


    public abstract IEnumerator SpawnWithDelay(BoxCollider2D boxCollider,  Transform pos, EnemySpawner spawner);


}
