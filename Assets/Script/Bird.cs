using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    private float Timer;
    private int frameNum = 10;
    private int frameCount = 0;
    private Rigidbody p_bird;

	// Use this for initialization
	void Start () {
        p_bird =  GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager._ins.GameState == GameManager.GAMESTATE_PLAYING)
        {
            
            Timer += Time.deltaTime;
            if (Timer >= 0.1f / frameNum)
            {
                frameCount++;
                Timer -= 0.1f / frameNum;
                int frameIndex = frameCount % 3;
                this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.33333f * frameIndex, 0));

            }


            if (Input.GetMouseButton(0))
            {
                this.GetComponent<AudioSource>().Play();

                Vector3 vel = p_bird.velocity;

                p_bird.velocity = new Vector3(vel.x, 5, vel.z);
            }
        }
	}

    public void getActive()
    {
        p_bird.useGravity = true;
        p_bird.velocity = new Vector3(3, 0, 0);
    }
}
