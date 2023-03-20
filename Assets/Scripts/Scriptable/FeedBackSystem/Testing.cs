using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.FeedBack
{
    [CreateAssetMenu(menuName = "SpaceJet/Feedback / feed")]
    public class Testing : AudioFeedBack
    {
        public override void PlayHit(AudioSource source, Transform where)
        {
            base.PlayHit(source, where);
        }
    }
}