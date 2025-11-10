using UnityEngine;

public class Fireballshooting : MonoBehaviour
{
    public GameObject fireball;
    public GameObject fireballSpawnPoint;
    private bool shootFireball = false;
    private float delay = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(delay > 0)
        {
            delay = delay - Time.deltaTime;
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (shootFireball == true)
                {
                    Instantiate(fireball, fireballSpawnPoint.transform.position, fireballSpawnPoint.transform.rotation);
                    delay = 0.5f;
                    shootFireball = false;

                }
                else
                {
                    shootFireball = true;
                }

        
            }
        }
    }
}
