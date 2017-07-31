using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovePlayer : MonoBehaviour {

	public static int health = 100;
	private int maxhealth=100;
	public GameObject screen;
	private float time;
	private float prevtime;

	private float score;

	public Transform canvas;
	public Transform pauseBtn; 
	public Transform batteryLow;

	public Material ground;
	public Material tunnel;

	public Text scoreTxt;


	void Start ()
	 {
		prevtime = 0f;
		time =0f;
		Time.timeScale=1;
		scoreTxt.text="";


	}
	
	void Update ()
	 {
		score = score+Time.deltaTime;
		
		if(transform.position.x<-8.5f || transform.position.x>-0.8)
		{
			health=0;
		}
		
		if(Time.timeScale==1)
		{
			transform.Translate(-(Input.acceleration.x),0,0);
		}
		
		ground.color = Color.Lerp(Color.red, Color.green, Mathf.PingPong(Time.time*0.5f, 1));
		tunnel.color = Color.Lerp(Color.yellow, Color.red, Mathf.PingPong(Time.time*0.6f, 1));
		
		if(health<=20)
		{
			batteryLow.gameObject.SetActive(true);
			screen.GetComponent<Renderer>().material.color = Color.grey;
		}
		else
		{
			batteryLow.gameObject.SetActive(false);

			screen.GetComponent<Renderer>().material.color = Color.white;
		}

		time+=Time.deltaTime;
		
		if((int)time%2==0 && (int)prevtime!=(int)time)
		{
			if(health-10<0)
			{
				health=0;
			}
			else
			{
				health-=10;
			}
			prevtime=(int)time;
		}

		if(health>=100)
		{
			health=100;
		}

		TextMesh textObject = GameObject.Find("Health").GetComponent<TextMesh>();
		textObject.text = health+"";


		if(health <=0)
		{
			health=0;
			canvas.gameObject.SetActive(true);
			pauseBtn.gameObject.SetActive(false);
			screen.GetComponent<Renderer>().material.color = Color.black;
			
			if(Time.timeScale!=0)
			{
						scoreTxt.text =scoreTxt.text+""+(int)score;

			}
			Time.timeScale=0;
		}


	}


}
