using UnityEngine;
using System.Collections;

public class pipend : MonoBehaviour {

    public AudioSource hitAudio;
    public AudioSource dieAudio;

	void OnCollisionEnter(Collision other)
    {
       
        if(other.gameObject.tag == "Player")
        {
            hitAudio.Play();
            dieAudio.Play();
            GameManager._ins.GameState = GameManager.GAMESTATE_END;
        }
    }

}
