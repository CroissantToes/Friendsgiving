using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private float xPos;
    private float yPos;
    private int enemyCount;
    public float xRangeMin;
    public float xRangeMax;
    public float yRangeMin;
    public float yRangeMax;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while(enemyCount < 4)
        {
            xPos = Random.Range(xRangeMin, xRangeMax);
            yPos = Random.Range(yRangeMin, yRangeMax);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
            enemyCount++;
        }
    }

}
