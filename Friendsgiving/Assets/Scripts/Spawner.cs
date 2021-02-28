using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
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
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(enemyCount < 4)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
            enemyCount++;
        }
        while(friendCount < 1)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
            friendCount++;
        }


    }

}
