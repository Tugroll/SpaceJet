using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.FeedBack
{
    public class FeedBack : MonoBehaviour
    {
        [SerializeField] AudioFeedBack FeedHitBackObject;
        [SerializeField] AudioFeedBack FeedDeathBackObject;
        AudioSource source;

        private void Awake()
        {
            source = GetComponent<AudioSource>();
        }
        public void InitializeHitFeedBackObject()
        {
            FeedHitBackObject.PlayHit(source, transform);
        }
        public void InitializeDeathFeedBackObject()
        {
            FeedDeathBackObject.PlayHit(source, transform);
        }
    }
}