using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackController : MonoBehaviour {

    public static TrackController singleton { get; private set; }
    private Dedemit currentlyActiveDedemit;

    [SerializeField]
    private List<ITrackObserver> observers = new List<ITrackObserver>();

    void Awake() {
        singleton = this;

        registerTrackObserver(FindObjectOfType<DedemitUI>());
    }

    public void setCurrentDedemit(Dedemit dedemit) {
        currentlyActiveDedemit = dedemit;
        notifyAllObservers();
    }

    public Dedemit getCurrentDedemit() {
        return currentlyActiveDedemit;
    }

    private void notifyAllObservers() {
        for (int i = 0; i < observers.Count; i++) {
            observers[i].OnTrackUpdate(this);
        }
    }

    public void registerTrackObserver(ITrackObserver newObserver) {
        observers.Add(newObserver);
    }
}
