using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class QuitButton : MonoBehaviour
{
    void Awake()
    {
        // On Android: pressing the back button minimizes/quits the app
        Input.backButtonLeavesApp = true;
    }

    public void doExitGame()
    {
        // If running inside the Unity Editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        // In builds, this will close the application
        Application.Quit();
    }
}
