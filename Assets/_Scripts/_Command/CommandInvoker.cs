using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Invoker
public class CommandInvoker : MonoBehaviour
{
    PlayerAction inputAction;
    static Queue<ICommand> commandBuffer;
    static List<ICommand> commandHistory;

    static int counter;

    void Start()
    {
        commandBuffer = new Queue<ICommand>();
        commandHistory = new List<ICommand>();

        inputAction = PlayerInputController.controller.inputAction;

        inputAction.Editor.Undo.performed += cntxt => UndoCommand();
    }

    public static void AddCommand(ICommand command)
    {
        while(commandHistory.Count > counter)
        {
            commandHistory.RemoveAt(counter);
        }
        commandBuffer.Enqueue(command);
    }

    public void UndoCommand()
    {
        if (commandBuffer.Count <= 0)
        {
            if(counter > 0)
            {
                counter--;
                commandHistory[counter].Undo();
            }
        }
    }

    private void Update()
    {
        if (commandBuffer.Count > 0)
        {
            ICommand c = commandBuffer.Dequeue();
            c.Execute();

            commandHistory.Add(c);
            counter++;
            Debug.Log("command history length: " + commandHistory.Count);
        }
    }
}
