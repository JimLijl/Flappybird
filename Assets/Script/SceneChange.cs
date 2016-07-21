using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
    
    public void OnClick()
    {
        Application.LoadLevel(1);
    }

    public void Exitgame()
    {
        Application.Quit();
    }
}
