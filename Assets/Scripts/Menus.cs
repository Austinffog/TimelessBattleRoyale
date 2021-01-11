using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public GameObject pauseMenu, gameOverMenu, victoryMenu;
    public AudioSource button;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Sound();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Sound();
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Victory()
    {
        victoryMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void StartMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
        Sound();
    }

    public void Restart_PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverMenu.SetActive(false);
        victoryMenu.SetActive(false);
        Time.timeScale = 1f;
        Sound();
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
        Sound();
    }

    public void Exit()
    {
        Application.Quit();
        Sound();
    }

    public void Sound()
    {
        button.Play();
    }
}

/*Sound
Freesound. 2021. Button Click 3 by Mellau, 14 Febraury 2020. [Online]. Available at: https://freesound.org/people/Mellau/sounds/506052/. [Accessed 10 January 2021]
*/
