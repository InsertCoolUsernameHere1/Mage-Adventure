using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void quitButton()
    {
       Application.Quit();
    }
}
