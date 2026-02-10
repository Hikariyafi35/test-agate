using UnityEngine;

public class CollideSpawnScript : MonoBehaviour
{
    public GameObject targetObject;
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
        targetObject = GetComponent<GameObject>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {   
            scoreManager.ScoreTrack(1);
            SpawnManager.Instance.PrefabsOff(); 
            gameObject.SetActive(false);
            
        }
    }
}
