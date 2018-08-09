using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DedemitUI : MonoBehaviour, ITrackObserver {

    private Canvas canvas;
    private Text dedemitNameText;
    private CommandButton lookAtButton, walkButton, viewLoreButton;
    private AreYouSurePanel panel;

	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();

        dedemitNameText = transform.Find("Dedemit Name Image").Find("Dedemit Name Text").GetComponent<Text>();
        lookAtButton = transform.Find("Look At Button").GetComponent<CommandButton>();
        walkButton = transform.Find("Walk Button").GetComponent<CommandButton>();
        viewLoreButton = transform.Find("View Lore Button").GetComponent<CommandButton>(); 
        panel = GetComponentInChildren<AreYouSurePanel>();

        lookAtButton.registerCommand(new ChangeDedemitStateCommand(new LookAtWalkState(Camera.main.transform, 0f)));
        walkButton.registerCommand(new ChangeDedemitStateCommand(new WalkState(0f)));
        viewLoreButton.registerCommand(new ShowPanelCommand(panel));

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void displayDedemitName(string name) {
        dedemitNameText.text = name;
    }

    public void OnTrackUpdate(TrackController controller) {
        if(!canvas)
            canvas = GetComponent<Canvas>();

        if (controller.getCurrentDedemit()) {
            canvas.enabled = true;
            displayDedemitName(controller.getCurrentDedemit().getDisplayName());
        }
        else {
            canvas.enabled = false;
        }

    }
}
