using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrackObserver {
    void OnTrackUpdate(TrackController controller);
}
