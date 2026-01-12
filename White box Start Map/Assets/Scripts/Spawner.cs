using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnerGuy;
    public int maxSpawns = 10;
    public int currentSpawns = 0;
    public float delay = 2f;
    public Transform maxX;
    public Transform maxZ;
    private float randomX;
    private float randomZ;
    public Transform spawnPosition;
    public Quaternion Q;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (currentSpawns < maxSpawns)  // Checks to see if a new enemy should be spawned in  or not
        {
            if (delay > 0)  // Adds a delay so that the enemies dont spawn all at once
            {
                delay = delay * Time.deltaTime;
            }
            else 
            {
                selectRandomSpawnPoint();
                currentSpawns = currentSpawns + 1;
                Instantiate(spawnerGuy, spawnPosition.position, Q);
                delay = 1f;
            }
        }
    }
    private void selectRandomSpawnPoint() // Allows the enemy to pick a random point to spawn in 
    {
        float distanceX = transform.position.x - maxX.position.x;
        float distanceZ = transform.position.z - maxX.position.z;

        randomX = Random.Range((transform.position.x + distanceX), maxX.position.x);
        randomZ = Random.Range((transform.position.z + distanceZ), maxX.position.z);
        spawnPosition.position = new Vector3(randomX, spawnPosition.position.y, randomZ);
        Q = Quaternion.Euler(new Vector3(0, Random.Range(0, 361), 0));
    }
}
