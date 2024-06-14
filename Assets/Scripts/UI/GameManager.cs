using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;  // Das Panel, das bei Game Over angezeigt wird
    public Transform player;  // Der Transform des Spielers
    public PlatformGenerator platformGenerator;  // Referenz zum PlatformGenerator
    private bool isGameOver = false;  // Zustand, ob das Spiel vorbei ist

    void Start()
    {
        gameOverPanel.SetActive(false);  // Verstecke das Game Over-Panel beim Start
        Time.timeScale = 1;  // Setze die Spielzeit fort, falls sie pausiert war
    }

    void Update()
    {
        if (!isGameOver && player.position.y < platformGenerator.GetLowestPlatformY() -2  )
        {
            Debug.Log("Spieler ist gefallen. Game Over.");
            GameOver();
        }
    }

    public void GameOver()
    {
        isGameOver = true;  // Setze den Zustand auf Game Over
        gameOverPanel.SetActive(true);  // Zeige das Game Over-Panel an
        Time.timeScale = 0;  // Pausiere das Spiel
        Debug.Log("Game Over angezeigt.");
    }

    public void RestartGame()
    {
        isGameOver = false;  // Setze den Game Over-Zustand zurück
        Time.timeScale = 1;  // Setze die Spielzeit fort
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Lade die aktuelle Szene neu
    }
    public void ExitToStartScreen()
    {
        Time.timeScale = 1;  // Setze die Spielzeit fort
        SceneManager.LoadScene("StartScreen");  // Ersetze "StartScene" durch den Namen deiner Startbildschirm-Szene
    }

}
