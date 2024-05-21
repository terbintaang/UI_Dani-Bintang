using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OakSpawner : MonoBehaviour
{
    [SerializeField] GameObject oakToSpawn;
    [SerializeField] float timeInterval;
    [SerializeField] float maxHeight;

    private float timer;

    private void Update()
    {
        if (timer > timeInterval)
        {
            SpawnOak();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnOak()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, Random.Range(-maxHeight, maxHeight));
        GameObject oakJustSpawned = Instantiate(oakToSpawn, spawnPos, Quaternion.identity);

        Destroy(oakJustSpawned, 10f);
    }
}
