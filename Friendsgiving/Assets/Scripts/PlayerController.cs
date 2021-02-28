using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    public int health;
    public float runSpeed;
    public Vector2 level2;
    public Vector3 level3;
    public Text lifeText;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        SetHealthText();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if(health == 4)
        {
            transform.position = level2;
            health = 1;
        }

        if(health == 4)
        {
            transform.position = level3;
            health = 1;
        }

        SetHealthText();
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Friend"))
        {
            Debug.Log("hit");
            other.gameObject.SetActive(false);
            health++;
        }
      

    }

    void SetHealthText()
    {
        lifeText.text = "Health: " + health.ToString();
    }
}
