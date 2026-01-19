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
        PlayerPrefs.GetFloat("finalTime");
        Cursor.visible = true;
    }
    public void retryButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
 
}
