using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public int health = 3;
    public Spawner s;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        s = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)  // Tell script when the enemy is dead 
        {
            if(s != null)
            {
                s.currentSpawns = s.currentSpawns - 1;
                s = null;
            }
            Destroy(gameObject);
        }

        
    }
}
