using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadbestScore : MonoBehaviour {

    public Text b_score;
    int bestScore;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("bestScore");
        showScore();
    }

    public void showScore()
    {
        Debug.Log(bestScore);
        b_score.text = bestScore + "";
    }
}
