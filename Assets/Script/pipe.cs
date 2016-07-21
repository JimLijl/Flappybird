using UnityEngine;
using System.Collections;

public class pipe : MonoBehaviour {

    private float Pos_y;

	// Use this for initialization
	void Start () {
        creatPosition();

    }
	
	// Update is called once per frame
	public void creatPosition() {
        Pos_y = Random.Range(-0.4f, -0.1f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, Pos_y, this.transform.localPosition.z);
	}

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            
            GameManager._ins.Score++;
            this.GetComponent<AudioSource>().Play();
        }
    }

   
}
