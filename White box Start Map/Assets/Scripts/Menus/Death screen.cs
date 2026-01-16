using UnityEngine;
using UnityEngine.SceneManagement;
public class Deathscreen : MonoBehaviour
{
    public StopWatch stopWatch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {
        Cursor.visible = true;
    }
    public void retryButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
