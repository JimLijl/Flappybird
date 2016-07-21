using UnityEngine;
using System.Collections;

public class FollowBird : MonoBehaviour {

    private GameObject p_bird;
    private Transform p_birdTransform;

	// Use this for initialization
	void Start () {

        p_bird = GameObject.FindGameObjectWithTag("Player");
        p_birdTransform = p_bird.transform;
	
	}
	
	// Update is called once per frame
	void Update () {

        float y = p_birdTransform.position.y - 1.03f;

        if(y > 1.62f)
        {
            y = 1.62f;
        }

        if(y < -1.62)
        {
            y = -1.62f;
        }

        this.transform.position = new Vector3(p_birdTransform.position.x+3.67f,y,-10f);

	}
}
