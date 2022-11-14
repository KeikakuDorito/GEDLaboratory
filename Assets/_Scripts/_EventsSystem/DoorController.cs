using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        GameEvents.current.onDoorwayTriggerEnter += onDoorwayOpen;

        GameEvents.current.onDoorwayTriggerExit += onDoorwayClose;
    }

    public void onDoorwayOpen()
    {
        anim.Play("DoorOpen");
    }

    public void onDoorwayClose()
    {
        anim.Play("DoorClose");
    }
}
