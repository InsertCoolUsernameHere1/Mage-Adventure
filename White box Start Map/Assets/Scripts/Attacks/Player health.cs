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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + maxHealth;
        healthBar.value = (float)health / (float)maxHealth; // Creates a percentage for the healthabr to use to see how much the bar should be filled
        if (health <= 0)
        {
            healthBar.gameObject.SetActive(false);
            Destroy(gameObject);
            SceneManager.LoadScene("Death screen"); // Loads up the death screen
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.tag == "Sword")
            {
                health = health - 2;  // Detects if an item with the tag "Sword is touching the players hitbox
            }
        }
    }
}