using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArmsController : MonoBehaviour
{
    private Animator armsAnimator;
    // Start is called before the first frame update
    void Start()
    {
        armsAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            armsAnimator.SetBool("isRunning", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            armsAnimator.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            armsAnimator.SetTrigger("punchLeft");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            armsAnimator.SetTrigger("punchRight");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Scene/CozyFirePlace", LoadSceneMode.Single);
        }
    }
}
