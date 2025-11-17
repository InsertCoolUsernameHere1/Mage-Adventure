using System.Collections;
using UnityEngine;

public class Fireballlogic : MonoBehaviour
{
    public GameObject objectToDestroy;
    public Rigidbody rb;
    public int speed = 25;
    public int damage = 50;
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


}

