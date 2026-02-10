using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollideScript : MonoBehaviour
{
    ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scoreManager.ScoreTrack(1);

            if (SpawnManager.Instance != null)
                SpawnManager.Instance.PrefabsOff();

            gameObject.SetActive(false);
        }
    }
}
