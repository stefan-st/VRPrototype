using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookController : MonoBehaviour
{
    Animator bookAnimator;
    // Start is called before the first frame update
    void Start()
    {
        bookAnimator = GetComponent<Animator>();
        bookAnimator.SetInteger("Level", SceneSettings.level);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            bookAnimator.SetTrigger("FlipPage");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bookAnimator.SetTrigger("FlipPageBack");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bookAnimator.GetCurrentAnimatorStateInfo(0).IsName("Page2Flip"))
            {
                SceneManager.LoadSceneAsync("Scenes/Amsterdam", LoadSceneMode.Single);
                SceneSettings.level = 1;
            }
        }
    }
}
