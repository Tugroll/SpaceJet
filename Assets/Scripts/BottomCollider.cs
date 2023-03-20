using SpaceJet.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCollider : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementController player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerMovementController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null && player!= null)
        {
           
            enemy.EnemyKilledOutsideBounds();
        }
    }
}
