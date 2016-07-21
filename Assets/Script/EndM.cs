using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndM : MonoBehaviour {

    public static EndM _ins;

    public Text newScore;
    public Text bestScore;

    void Awake()
    {
        _ins = this;
    }

    public void UpdateScore(int n_Score)
    {

        int b_Score = PlayerPrefs.GetInt("bestScore", 0);

        if (n_Score > b_Score)
        {
            b_Score = n_Score;
        }

        PlayerPrefs.SetInt("bestScore",b_Score);

        newScore.text = n_Score+"";
        bestScore.text = b_Score+"";

    }

    public void OnClick()
    {
        Application.LoadLevel(1);
    }

    public void BackToStart()
    {
        Application.LoadLevel(0);
    }

    
}
