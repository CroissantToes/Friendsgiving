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
                lines.text = "You used to feed the birds with your wife, but that was a long time ago.";
                lineCounter++;
            }
            else if (lineCounter == 1)
            {
                lines.text = "She's gone now. The only time you still feel close to her is when you go see the birds.";
                lineCounter++;
            }
            else if (lineCounter == 2)
            {
                lines.text = "Reclaim your happiness by collecting bird friends.";
                lineCounter++;
            }
            else
            {
                screen.gameObject.SetActive(false);
                player.gameObject.SetActive(true);
                enemies.gameObject.SetActive(true);
            }
        }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
