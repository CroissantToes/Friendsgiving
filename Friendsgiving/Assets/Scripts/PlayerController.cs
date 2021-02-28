using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    public int health;
    public float runSpeed;
    public Vector2 level2;
    public Vector2 level3;
    public Text lifeText;
    public GameObject nextLevel;
    public GameObject victory;
    private int levelCounter = 0;
    private GameObject[] friends;
    private GameObject[] enemies;



    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        SetHealthText();
    }

    void Update()
    {
        //gets directional input from keyboard
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //checks health amount
        if (levelCounter == 0 && health == 3)
        {
            NextLevelScreen();
            transform.position = level2;
            Destroyer();
            levelCounter++;
            
        }
        else if (levelCounter == 1 && health == 4)
        {
            NextLevelScreen();
            transform.position = level3;
            Destroyer();
            levelCounter++;
            
        }
        else if (levelCounter == 2 && health == 5)
        {
            Destroyer();
            victory.gameObject.SetActive(true);
            
        }

        //game over
        if (health < 1)
        {
            StartOver();
        }

        SetHealthText();
    }

  

    private void FixedUpdate()
    {
        //moves character
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    //interactions with friends and enemies
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Friend"))
        {
            //Debug.Log("hit");
            other.gameObject.SetActive(false);
            health++;
            Spawner.friendCount--;
        }
        else
        {
            other.gameObject.SetActive(false);
            health--;
            Spawner.enemyCount--;
        }
      

    }

    //changes health display
    void SetHealthText()
    {
        lifeText.text = "Health: " + health.ToString();
    }

    void NextLevelScreen()
    {
        nextLevel.gameObject.SetActive(true);
    }

    public void NextLevel()
    {
        nextLevel.gameObject.SetActive(false);
    }

    public void StartOver()
    {
        SceneManager.LoadScene("Main");
    }

    void Destroyer()
    {
        friends = GameObject.FindGameObjectsWithTag("Friend");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject item in friends)
 {
            Destroy(item);
        }
        foreach (GameObject item in enemies)
 {
            Destroy(item);
        }
        health = 1;
    }
}
