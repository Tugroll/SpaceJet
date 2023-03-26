using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceJet.Observe
{
    public abstract class AbstractSubject : MonoBehaviour
    {
        private List<Observer> observer = new List<Observer>();
        public void AddObserver(Observer action)
        {
            observer.Add(action);
        }
        public void RemoveObserver(Observer action)
        {
            observer.Remove(action);
        }
        public void OnNotify(ActionData action)
        {
            observer.ForEach((observers) => { observers.OnNotify(action); });
        }
    }


}

