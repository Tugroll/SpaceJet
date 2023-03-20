using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SpaceJet/ Spawner / EnemySpawn")]
public class SpawnEnemy : EnemySpawnerBase
{
    public List<Enemy> enemy = new List<Enemy>();


    public override IEnumerator SpawnWithDelay(BoxCollider2D boxCollider, Transform pos, EnemySpawner spawner)
    {
        currentEnemy.Clear();
        currentWave = 0;
        while (true)
        {
           
            yield return new WaitForSeconds(startDelay);

            float minX = boxCollider.bounds.min.x;
            float maxX = boxCollider.bounds.max.x;

            for (int i = 0; i < maxEnemies; i++)
            {
                int randomke = UnityEngine.Random.Range(0, 2);
                Vector3 spawnPoint = new Vector3(UnityEngine.Random.Range(minX, maxX), pos.position.y, 0);
                GameObject newEnemy = Instantiate(enemy[randomke].gameObject, spawnPoint, Quaternion.Euler(0, 0, -90));
                currentEnemy.Add(newEnemy);
                newEnemy.GetComponent<Enemy>().enemySpawner = spawner;
                yield return new WaitForSeconds(UnityEngine.Random.Range(timeMin, timeMax));
            }


            currentWave++;
        }
       
    }


}
