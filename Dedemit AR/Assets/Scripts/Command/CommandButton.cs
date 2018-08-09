using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandButton : Button {

    private List<ICommand> commands = new List<ICommand>();

    new void Start() {
        base.Start();
        onClick.AddListener(() => { executeCommand(); });
    }

    public void registerCommand(ICommand command) {
        commands.Add(command);
    }

    private void executeCommand() {
        for (int i = 0; i < commands.Count; i++) {
            commands[i].execute();
        }
    }
}
