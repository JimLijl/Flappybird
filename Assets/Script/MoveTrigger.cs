using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour {

    public Transform currentBg;
    public pipe pipe1;
    public pipe pipe2;


	public void OnTriggerEnter(Collider other)
    {
        

        if(other.tag == "Player")
        {
            Transform firstBg = GameManager._ins.firstBg;

            currentBg.position = new Vector3(firstBg.position.x + 10, currentBg.position.y, currentBg.position.z);

            GameManager._ins.firstBg = currentBg;

            pipe1.creatPosition();
            pipe2.creatPosition();
        }
    }
}
