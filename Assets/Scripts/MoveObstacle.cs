using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour {
	public AudioSource beep;

	void Update () 
	{
		transform.Translate(Vector3.forward*Time.deltaTime*6f);
		
		if(transform.position.z>-8f)
		{
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter (Collision col)
    {

        if(col.gameObject.name == "Player" || col.gameObject.tag == "Player")
        {
			if(MovePlayer.health-20<0)
			{
				MovePlayer.health=0;
			}
			else
			{
				MovePlayer.health-=20;
			}

			Destroy(gameObject);

		}
    }


}
