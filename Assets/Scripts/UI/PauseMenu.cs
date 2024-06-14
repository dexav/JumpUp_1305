using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    void Start()
    {
        pausePanel.SetActive(false);  // Verstecke das Pausenmen� beim Start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausePanel.activeSelf)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);  // Zeige das Pausenmen� an
        Time.timeScale = 0;  // Pausiere das Spiel
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);  // Verstecke das Pausenmen�
        Time.timeScale = 1;  // Setze das Spiel fort
    }
    public void ExitToStartScree()
    {
        Time.timeScale = 1;  // Setze die Spielzeit fort
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScreen");  // Lade die Startszene
        
    }

}
