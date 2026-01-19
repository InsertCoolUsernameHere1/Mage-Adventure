using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class StopWatch : MonoBehaviour
{
    bool stopwatchActive = true;
    public float currentTimeScript;
    public Text currentTimeText;
    public float currentTime;
    public Playerhealth Playerhealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTimeScript = 0; //Current time
        currentTime = PlayerPrefs.GetFloat("currentTime"); // Highest Time

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (stopwatchActive == true)
        {
            currentTimeScript = currentTimeScript + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTimeScript);
        currentTimeText.text = time.ToString() + ":" + time.Seconds.ToString();
        if(sceneName == "Tutorial")
        {
            if (Playerhealth.health <= 0 ) // Checks to see if the player is on the "Tutorial scene, 
            {
                stopwatchActive = false;

                if (currentTime < currentTimeScript)  // when they die it checks if the time that was just recorded is higher than the overall high score
                {
                    PlayerPrefs.SetFloat("currentTime", currentTimeScript);  // if so will change the high score with current score
                    PlayerPrefs.Save();

                    currentTimeText.text = currentTime.ToString();

                }
                else
                {
                    currentTimeText.text = currentTime.ToString();
                }

            }
        }

        if (sceneName == "Death screen") // This just makes sure it still works ("dont fix what doesnt need fixing") 
        {
                stopwatchActive = false;

                if (currentTime < currentTimeScript)  
                {
                    PlayerPrefs.SetFloat("currentTime", currentTimeScript);
                    PlayerPrefs.Save();

                    currentTimeText.text = currentTime.ToString();

                }
                else
                {
                    currentTimeText.text = currentTime.ToString();
                }

            
        }
    }


}
