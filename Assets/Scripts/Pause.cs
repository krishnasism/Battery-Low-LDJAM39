using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

		public Transform canvas;
		public Transform pauseBtn;

		public void pauseBtnPress()
		{
			canvas.gameObject.SetActive(true);
			pauseBtn.gameObject.SetActive(false);
			Time.timeScale = 0;

		}
		public void resumeBtnPress()
		{
			Time.timeScale=1;
			canvas.gameObject.SetActive(false);
			pauseBtn.gameObject.SetActive(true);
		}
		public void exitBtnPress()
		{
			SceneManager.LoadScene("MainMenu");
		}

		public void newGameBtn()
		{
			Time.timeScale = 1;
			MovePlayer.health=100;
			SceneManager.LoadScene("Level1");
		}
}
