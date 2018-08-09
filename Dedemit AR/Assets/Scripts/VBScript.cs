using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vButtonObject, zombie;

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        zombie.GetComponent<Animator>().enabled = true; 
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        zombie.GetComponent<Animator>().enabled = false;
    }

    void Start () {
        vButtonObject = GameObject.Find("actionButton");
        vButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

}
