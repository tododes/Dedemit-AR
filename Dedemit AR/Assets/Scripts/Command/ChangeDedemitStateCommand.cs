using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDedemitStateCommand : ICommand
{
    private Dedemit dedemit;
    private IDedemitState newState;

    public ChangeDedemitStateCommand(IDedemitState newState) {
        this.newState = newState;
    }

    public void execute() {
        dedemit = TrackController.singleton.getCurrentDedemit();
        dedemit.setState(newState);
    }
}
