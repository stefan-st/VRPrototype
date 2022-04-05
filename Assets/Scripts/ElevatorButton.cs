using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElevatorButton : XRBaseInteractable
{
    private Animator buttonAnimator;
    private LoadLevel levelManager;
    public GameObject sceneM;
    // Start is called before the first frame update
    void Start()
    {
        buttonAnimator = GetComponent<Animator>();
        levelManager = sceneM.GetComponent<LoadLevel>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        buttonAnimator.SetTrigger("ButtonPushed");

/*        if (gameObject.name == "ElevatorButton.004")
        {
            LoadLevel.levelName = "Amsterdam";
            levelManager.EditorLoadLevel();
        }
        if (gameObject.name == "ElevatorButton.001") LoadLevel.levelName = "Forest";
        if (gameObject.name == "ElevatorButton.002") LoadLevel.levelName = "Grief";*/
    }
}
