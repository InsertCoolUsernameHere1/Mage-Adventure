using UnityEngine;

public class Fireballshooting : MonoBehaviour
{
    public GameObject Fireball;
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
                    Instantiate(Fireball, fireballSpawnPoint.transform.position, fireballSpawnPoint.transform.rotation);  
                    delay = 0.25f;  // No you arent getting a fully automatic fireball launcher (has a .5 second delay per fireball)
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
