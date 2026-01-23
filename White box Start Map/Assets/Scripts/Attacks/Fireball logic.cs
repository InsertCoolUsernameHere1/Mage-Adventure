using System.Collections;
using UnityEngine;
using System.Collections.Generic;



public class Fireballlogic : MonoBehaviour
{
    public GameObject objectToDestroy;
    public Rigidbody rb;
    public int speed = 25;
    public EnemyLogic EnemyL;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Destroy(objectToDestroy);
        Invoke("FunctionToDestroy", 3f);

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = transform.forward * speed;
    }

    void FunctionToDestroy()
    {
        Destroy(objectToDestroy);
    }

    IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(4f);  // Fireball go boom after 4 seconds (destroys the fireball)
        Destroy(objectToDestroy);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyL = other.gameObject.GetComponent<EnemyLogic>(); // Fireball hurt enemy and do 1 damage
            EnemyL.health = EnemyL.health - 1;
            Destroy(gameObject);
        }
    }
}

