using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    private Animator buttonAnimator;
    // Start is called before the first frame update
    void Start()
    {
        buttonAnimator = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonAnimator.SetTrigger("ButtonPushed");
    }
}
