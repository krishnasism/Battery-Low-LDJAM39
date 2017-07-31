using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	float x;
	float y;
	float z;
	public GameObject spark;
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = false;
		Input.gyro.enabled = true;
		transform.rotation=Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {

	 if(Time.timeScale != 0)
	 {
	 	transform.rotation  = new Quaternion(Input.gyro.attitude.x,Input.gyro.attitude.y,Input.gyro.attitude.z,0);
	 }
	}
	void OnTriggerEnter(Collider other)
	 {

	 		if(MovePlayer.health+5>100)
	 		{
	 			MovePlayer.health=100;

	 		}
	 		else
	 		{
 				MovePlayer.health+=5;
 			}
 			Instantiate(spark, gameObject.transform.position, Quaternion.identity);
 		}
     }
