using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField]
    private float maxSpawnRateInSeconds = 2f;

    void Start()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);
        InvokeRepeating("IncreaseSpawnRate", 0f, 100f);
    }

    void Update()
    {
        //
    }

    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject anEnemy = (GameObject)Instantiate(enemy);
        anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

        NextSpawn();
    }

    void NextSpawn()
    {
        float spawnInSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }

        else
        {
            spawnInSeconds = 1f;
        }
            
        Invoke("SpawnEnemy", spawnInSeconds);
    }

    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
        {
            maxSpawnRateInSeconds--;
        }
            
        if (maxSpawnRateInSeconds == 1f)
        {
            CancelInvoke("IncreaseSpawnRate");
        }   
    }
}
