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
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        Debug.Log(friendCount);
    }

    IEnumerator Spawn()
    {
        while (friendCount < 1)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(friend, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            friendCount++;
        }
        while(enemyCount < 4)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            enemyCount++;
        }
        


    }

}
