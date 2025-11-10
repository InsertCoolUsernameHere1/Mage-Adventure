using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEditor.Experimental.GraphView;
using System.Runtime.CompilerServices;

public class NPCPatrol : MonoBehaviour
{
    public Vector3[] patrolPoints;
    public int currentPatrolIndex;
    public float pauseDuration = 1.5f;
    public Vector3 target;
    public float speed = 2;
    private bool isPaused;
    private Rigidbody rb;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = patrolPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            rb.linearVelocity = Vector3.zero;
            return;
        }
        Vector3 direction = (target - transform.position).normalized;
        rb.useGravity = false;
        rb.linearVelocity = direction * speed;
        if (Vector3.Distance(transform.position, target) < .1f)
            StartCoroutine(SetPatrolPoint());
    }



    IEnumerator  SetPatrolPoint()
    {
        isPaused = true;
        yield return new WaitForSeconds(pauseDuration);
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        target = patrolPoints[currentPatrolIndex];
        isPaused = false;
    }
}

