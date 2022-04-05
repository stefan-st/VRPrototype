using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PolaroidInteractable : XRBaseInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);

        Material m = gameObject.GetComponent<Material>();
        m.color = Color.red;
        Debug.Log("Hover entered");
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        Material m = gameObject.GetComponent<Material>();
        m.color = Color.red;
        Debug.Log("Hover exited");
    }
}
