using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedemitFactory : MonoBehaviour {

    [SerializeField]
    private Dedemit dedemitPrefab;

    public Dedemit spawnDedemit() {
        return Instantiate(dedemitPrefab, transform.position, Quaternion.identity);
    }
}
