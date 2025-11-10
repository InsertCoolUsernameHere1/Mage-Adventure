using UnityEngine;

public class Fireballlogic : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = transform.forward * speed;
    }
}
