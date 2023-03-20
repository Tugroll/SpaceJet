using SpaceJet.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeathUI : MonoBehaviour
{





    public InGameMenu loseScreen;

    [SerializeField] private Transform liveImagesUIParent;
    List<Image> lives = new List<Image>();

    [SerializeField] Health _health;
    private int startingHealth = 3;




    private void OnEnable()
    {
        if (_health == null)
        {
            _health = GetComponent<Health>();
            _health.InitializeHealth(startingHealth);
        }

        _health.OnHit.AddListener(UpdateUI);
        _health.OnDeath.AddListener(UpdateUI);
        _health.OnDeath.AddListener(Death);

    }
    private void OnDisable()
    {
        _health.OnDeath.RemoveAllListeners();
        _health.OnHit.RemoveAllListeners();
        

    }
    private void UpdateUI()
    {
        for (int i = 0; i < lives.Count; i++)
        {
            if (i >= _health.CurrentHealth)
            {
                lives[i].color = Color.black;
            }
            else
            {
                lives[i].color = Color.white;
            }

        }
    }

    private void Death()
    {


        GetComponent<Collider2D>().enabled = false;
        GetComponentInChildren<SpriteRenderer>().enabled = false;
        StartCoroutine(DestroyCoroutine());
    }
    private IEnumerator DestroyCoroutine()
    {

        yield return new WaitForSeconds(1);
        Destroy(gameObject);

        loseScreen.Toggle();

    }



}
