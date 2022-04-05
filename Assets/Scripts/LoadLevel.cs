using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [ContextMenuItem("Load Level", nameof(EditorLoadLevel))]
    [ContextMenuItem("Load Level 2", nameof(EditorLoadLevel))]
    public static string levelName = "HospitalHallway";
    private bool isPressed = false;

    private string loadedLevelName = "HospitalHallway";


    private void Update()
    {

    }

    [ContextMenu("Load Level - Context Menu")]
    public void EditorLoadLevel()
    {
        StartCoroutine(LoadLevelAsync());
    }

    private IEnumerator LoadLevelAsync()
    {
        if (!string.IsNullOrEmpty(loadedLevelName))
        {
            var unloadProgress = SceneManager.UnloadSceneAsync(loadedLevelName);

            while (!unloadProgress.isDone)
            {
                yield return null;
            }
        }

        var progress = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        loadedLevelName = levelName;

        while (!progress.isDone)
        {
            yield return null;
        }

    }
}
