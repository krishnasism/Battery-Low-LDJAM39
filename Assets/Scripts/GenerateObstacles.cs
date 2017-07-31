using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {

	public GameObject obstacle;
	public GameObject light;

	public GameObject [] spawn = new GameObject[12];
	public GameObject [] lspawn = new GameObject[2];

	float time=5;
	float prevtime;
	void Start () {
		
	}
	
	void Update ()
	 {
		time=time+Time.deltaTime;

		if((int)prevtime!=(int)time)
		{

			Instantiate(obstacle, spawn[(int)Random.Range(0,11)].transform.position,Quaternion.identity);
			Instantiate(obstacle, spawn[(int)Random.Range(0,11)].transform.position,Quaternion.identity);
			Instantiate(obstacle, spawn[(int)Random.Range(0,12)].transform.position,Quaternion.identity);

			if(time>30)
			{
			Instantiate(obstacle, spawn[(int)Random.Range(0,11)].transform.position,Quaternion.identity);
			Instantiate(obstacle, spawn[(int)Random.Range(0,11)].transform.position,Quaternion.identity);
			Instantiate(obstacle, spawn[(int)Random.Range(0,11)].transform.position,Quaternion.identity);

			}
			Instantiate(light, lspawn[1].transform.position,Quaternion.identity);
			Instantiate(light, lspawn[0].transform.position,Quaternion.identity);

			prevtime=(int)time;
		}


	}
}
