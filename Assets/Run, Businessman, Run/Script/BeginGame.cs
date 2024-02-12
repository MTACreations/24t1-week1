using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
