using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.FeedBack
{
    public abstract class AudioFeedBack : ScriptableObject
    {

        public AudioClip clip;
        public GameObject VFX;

        public virtual void PlayHit(AudioSource source, Transform where)
        {
            source.PlayOneShot(clip);
            Instantiate(VFX, where.position, Quaternion.identity);
        }

        //private void Awake()
        //{
        //    source = GetComponent<AudioSource>();
        //}
        //void Start()
        //{
        //    source.PlayOneShot(clip);
        //}

        //IEnumerator DestroyAfterEnd()
        //{
        //    yield return new WaitForSeconds(clip.length);
        //    Destroy(gameObject);
        //}

    }
}