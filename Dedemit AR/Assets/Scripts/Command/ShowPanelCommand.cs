using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelCommand : ICommand
{
    private AreYouSurePanel panel;

    public ShowPanelCommand(AreYouSurePanel panel) {
        this.panel = panel;
    }

    public void execute()
    {
        panel.Trigger();
    }
}
