using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElevatorButton : XRBaseInteractable
{
    private Animator buttonAnimator;
    // Start is called before the first frame update
    void Start()
    {
        buttonAnimator = GetComponent<Animator>();        
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        buttonAnimator.SetTrigger("ButtonPushed");

        if (gameObject.name == "ElevatorButton") LoadLevel.levelName = "Amsterdam";
        if (gameObject.name == "ElevatorButton.001") LoadLevel.levelName = "Forest";
        if (gameObject.name == "ElevatorButton.002") LoadLevel.levelName = "Grief";
    }
}
