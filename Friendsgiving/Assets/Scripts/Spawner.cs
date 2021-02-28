using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject friend;
    private float xPos;
    private float yPos;
    public static int enemyCount;
    public static int friendCount;
    public float xRangeMin;
    public float xRangeMax;
    public float yRangeMin;
    public float yRangeMax;
    
    // Start is called before the first frame update
    void Start()
    {
        
        friendCount = 0;
        enemyCount = 0;
    }

    private void Update()
    {
        //Debug.Log(friendCount);
        //Debug.Log(enemyCount);
        if (friendCount < 1)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(friend, new Vector3(xPos, yPos, 0), Quaternion.identity);
            friendCount++;
           // Debug.Log("spawn friend");
        }
        if (enemyCount < 3)
        {
            while (enemyCount < 4)
            {
                xPos = Random.Range(xRangeMin, xRangeMax);
                yPos = Random.Range(yRangeMin, yRangeMax);
                Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
                
                enemyCount++;
                //Debug.Log("spawn enemy");
            }
        }
    }



   
}
