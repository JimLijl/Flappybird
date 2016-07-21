using UnityEngine;
using System.Collections;

public class ScoreCheck : MonoBehaviour {

    public GameObject S_Look;
    public GameObject SL_MoveTo;

	public void OnClick()
    {
        iTween.MoveTo(S_Look, SL_MoveTo.transform.position,0.5f);
    }
}
