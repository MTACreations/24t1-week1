using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public bool paused;
    public GameObject pauseScreen;

    public void Start()
    {
        paused = false;
        Time.timeScale = 1;
    }

    public void FixedUpdate()
    {
        if (Input.GetKey("q") && !paused)
        {
            paused = true;
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
        }
    }

    public void Resume()
    {
        paused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
