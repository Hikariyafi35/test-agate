using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    public GameObject enemyPrefab;

    public int startSpawnCount = 8;
    public float radiusX = 5f;
    public float radiusY = 5f;
    public float respawnDelay = 3f;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        for (int i = 0; i < startSpawnCount; i++)
        {
            SpawnPrefabs();
        }
    }

    public void PrefabsOff()
    {
        Debug.Log("Respawn dipanggil");
        StartCoroutine(ReSpawnPrefabs());
    }

    IEnumerator ReSpawnPrefabs()
    {
        yield return new WaitForSeconds(respawnDelay);
        SpawnPrefabs();
    }

    void SpawnPrefabs()
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy Prefab belum di-assign!");
            return;
        }

        float randomX = Random.Range(-radiusX, radiusX);
        float randomY = Random.Range(-radiusY, radiusY);

        Vector3 spawnPos = transform.position + new Vector3(randomX, randomY, 0);

        Debug.Log("Spawn di: " + spawnPos);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}