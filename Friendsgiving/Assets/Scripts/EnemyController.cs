using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed;
    public float stopDistance;
    private Transform target;

    private Animator animator;

    Rigidbody2D rb;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
            Vector3 movementDirection = target.position - transform.position;
            movementDirection = movementDirection.normalized;
            animator.SetFloat("moveX", (movementDirection.x));
            animator.SetFloat("moveY", (movementDirection.y));
    }
}
