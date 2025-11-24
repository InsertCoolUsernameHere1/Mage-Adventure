using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Callbacks;


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
        Invoke("FunctionToDestroy", 5f);

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
        yield return new WaitForSeconds(5f);
        Destroy(objectToDestroy);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyL = other.gameObject.GetComponent<EnemyLogic>();
            EnemyL.health = EnemyL.health - 1;
            Destroy(gameObject);
        }
    }
}

