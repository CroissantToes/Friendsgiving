using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject screen;
    public Text lines;
    public int lineCounter = 0;

    public GameObject player;
    public GameObject enemies;
    public GameObject enemySpawner;
    public GameObject friendSpawner;
    public AudioSource music;
    public Font newFont;

    // Start is called before the first frame update
    void Start()
    {
        lines.text = "Birdman";
    }

    // Update is called once per frame
    void Update()
    {

        //Quits game
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("escape key pressed!");
            LeaveGame();
        }
    }
    public void NextLine()
        {
            if (lineCounter == 0)
            {
                lines.font = newFont;
                lines.text = "You remember feeding the birds with your wife.";
                lineCounter++;
            }
            else if (lineCounter == 1)
            {
                lines.text = "After she left, it’s been harder to make friends.";
                lineCounter++;
            }
            else if (lineCounter == 2)
            {
                lines.text = "Maybe if you make some friends, you’ll be happier… \n collect bird friends to build happiness!";
                lineCounter++;
            }
            else
            {
            //starts first level
            //Debug.Log("working");
                screen.gameObject.SetActive(false);
                player.gameObject.SetActive(true);
                enemies.gameObject.SetActive(true);
                enemySpawner.gameObject.SetActive(true);
                friendSpawner.gameObject.SetActive(true);
                music.Play();

            }
        }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
