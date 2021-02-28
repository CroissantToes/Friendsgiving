using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int yPos;
    public int enemyCount;
    public int xRangeMin;
    public int xRangeMax;
    public int yRangeMin;
    public int yRangeMax;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while(enemyCount < 5)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
            enemyCount++;
        }
    }

}
