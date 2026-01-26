using UnityEngine;
using UnityEngine.SceneManagement;
public class Deathscreen : MonoBehaviour
{
    public StopWatch stopWatch;
    public string currentTimeText;
    public static string finalTime;
    public Playerhealth Playerhealth;
    public PlayerPrefs playerPrefs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {
        PlayerPrefs.GetFloat("finalTime");  // Maybe this time you did better? (displays highest time)
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void retryButton()  // Try again.... and no skill issues this time  (restarts the game)
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void quitButton()  // This is for the rage quitters (quits the game)
    {
        Application.Quit();
    }
 
}
