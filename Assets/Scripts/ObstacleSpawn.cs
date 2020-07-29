using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab1;
    public Transform[] spawnPoints;

    private float timeBetweenWaves = 1.5f;

    private float timeToSpawn = 1.5f;

    void Update ()
    {
        if (Time.time>= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
            timeBetweenWaves = timeBetweenWaves - 0.01f;
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, 5);
        int randomIndex1 = Random.Range(5, 7);
        int randomIndex2 = Random.Range(7, 9);
        int pickObstacle = Random.Range(0, 5);

        if (pickObstacle == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                if (randomIndex != i)
                {
                    Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
                }
            }
        }
        else if (pickObstacle == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i%2==1)
                {
                    Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
                }
            }
        }
        else if (pickObstacle == 2)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
                }
            }
        }
        else if (pickObstacle == 3)
        {
            for (int i = 5; i < 7; i++)
            {
                if (randomIndex1 == i)
                {
                    Instantiate(obstaclePrefab1, spawnPoints[i].position, Quaternion.identity);
                }
            }
        }
        else
        {
            for (int i = 7; i < 9; i++)
            {
                    Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
