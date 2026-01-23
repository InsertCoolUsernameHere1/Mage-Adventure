using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
    public int health = 10;
    public Slider healthBar;
    public TMP_Text healthText;
    public int maxHealth = 10;
    public StopWatch stopWatch;
    private bool stopwatchActive;
    private int healthPackValue = 5;
    public static string finalTime;
    public static string currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if (PlayerPrefs.HasKey(currentTime))
        //{
        //    finalTime = PlayerPrefs.GetString(currentTime);
        //}
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthPack.hasPickedUpHealthPack)
        {

            health = health + healthPackValue;
            HealthPack.hasPickedUpHealthPack = false;

            if (health > maxHealth)
            {
                health = maxHealth;  // Player has alot of health and cant get more 
            }
        }

        healthText.text = health + " / " + maxHealth;
        healthBar.value = (float)health / (float)maxHealth; // Creates a percentage for the healthabr to use to see how much the bar should be filled
        if (health <= 0)
        {
            finalTime = stopWatch.currentTimeText.ToString();
            healthBar.gameObject.SetActive(false);
            Destroy(gameObject);  // Player is now..... unalived
            stopwatchActive = false;
            PlayerPrefs.SetString(currentTime, finalTime);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Death screen"); // Loads up the death screen
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.tag == "Sword")
            {
                health = health - 2;  // Detects if an item with the tag "Sword is touching the players hitbox and if so takes away 2 health from pool
            }
        }
    }

}