using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SpaceJet/ Spawner / ObstacleSpawn")]
public class SpawnObstacles : EnemySpawnerBase
{
    public GameObject meteor;
    public override IEnumerator SpawnWithDelay(BoxCollider2D boxCollider, Transform pos, EnemySpawner spawner)
    {
        while (true)
        {
            yield return new WaitForSeconds(startDelay);
            float minX = boxCollider.bounds.min.x;
            float maxX = boxCollider.bounds.max.x;
            for (int i = 0; i < 16; i++)
            {
                Vector3 spawnPoint = new Vector3(minX + (i * 2), pos.position.y, 0);
                GameObject newEnemy = Instantiate(meteor, spawnPoint, Quaternion.Euler(0, 0, -90));
            }
        }
    }
}
