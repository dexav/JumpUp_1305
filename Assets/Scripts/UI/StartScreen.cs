using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public void StartGame()
    {
        // Lade die Szene mit dem Spiel

        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
    public void ExitGame()
    {
        // Beende das Spiel
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;  // Beendet das Spiel im Editor
        #endif
    }

}
