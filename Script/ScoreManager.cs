using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    public int scoreCounted = 0;
    [SerializeField]
    TMP_Text scoreText;

    private void Update() {
        Debug.Log(scoreCounted);
    }
    public void ScoreTrack(int value)
    {
        scoreCounted += value;
        scoreText.text = scoreCounted.ToString();
    }
}
