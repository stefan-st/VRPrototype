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
        Debug.Log("Got animator");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pushed");
        buttonAnimator.SetTrigger("ButtonPushed");
    }
}
