using UnityEngine;

public interface IHittable
{
    public void GetHit(int DamageValue, GameObject Sender);
}
