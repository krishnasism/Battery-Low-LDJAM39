using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
 {
 	void Start()
 	{
 		Time.timeScale=1;
 	}

	public void newGameBtn(string newGameLevel)
	{
		SceneManager.LoadScene(newGameLevel);
	}

	public void quitGameBtn()
	{
		Application.Quit();
	}

}
