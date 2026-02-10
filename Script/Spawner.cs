using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject itemPrefabs;
    public float radiusX = 1f;
    public float radiusY = 1f;
    public int spawnCount = 8;

    private void Start()
    {
        for (int i = 0; i <= spawnCount; i++)
        {
            SpawnObjectRandom();
        }
    }
    void SpawnObjectRandom()
    {
        float randomX = Random.Range(-radiusX, radiusX);
        float randomY = Random.Range(-radiusY, radiusY);
        Vector3 randomPos = new Vector3(randomX, randomY, 0);

        
            Instantiate(itemPrefabs, randomPos, Quaternion.identity);
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(this.transform.position, new Vector3(radiusX * 2, radiusY * 2, 1));
    }

}
