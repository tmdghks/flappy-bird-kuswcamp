using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // PipePair prefab
    public float spawnRate = 2f; // Time interval between spawns
    public float minY = 3f, maxY = 6f; // Random height range for pipes
    public float spawnX = 5f; // X position where pipes appear

    public float timer = 0f; // timer to keep track of time

    void Update()
    {
        // Repeatedly spawn pipes
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // Randomize Y position within given range
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0f);

        // Instantiate a new pipe
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}