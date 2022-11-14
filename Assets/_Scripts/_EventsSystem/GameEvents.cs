using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    public void Awake()
    {
        if (!current)
        {
            current = this;
        }
    }

    public event Action onDoorwayTriggerEnter;
    public void DoorwayTriggerEnter()
    {
        if(onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter(); 
        }
    }

    public event Action onDoorwayTriggerExit;
    public void DoorwayTriggerExit()
    {
        if (onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit();
        }
    }

}
