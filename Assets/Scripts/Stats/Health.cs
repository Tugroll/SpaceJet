using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceJet.Stats
{
    public  class Health : MonoBehaviour, IHittable
    {
        
        [field: SerializeField]

        public float CurrentHealth { get; private set; }

        public UnityEvent OnDeath, OnHit;

        
        public  void InitializeHealth(float startingHealth)
        {
            CurrentHealth = startingHealth;
        }

        public  void GetHit(int DamageValue, GameObject Sender)
        {
            CurrentHealth -= DamageValue;

            if (CurrentHealth <= 0)
            {
                CurrentHealth = 0;
                OnDeath?.Invoke();
            }
            else
            {
                OnHit?.Invoke();
            }
        }

        
    }
}