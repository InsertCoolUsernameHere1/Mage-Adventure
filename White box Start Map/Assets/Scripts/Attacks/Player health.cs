using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    public int health = 10;
    public Slider healthBar;
    public TMP_Text healthText;
    public int maxHealth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + maxHealth;
        healthBar.value = (float)health / (float)maxHealth;
        if (health <= 0)
        {
            healthBar.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        {
            if (other.gameObject.tag == "Sword")
            {
                health = health - 2;
            }
        }
    }
}