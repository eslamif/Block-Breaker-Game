using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(string name) {
		Application.Quit();
	}	

	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed() {
		//If the last break is destroyed, load the next level
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}	
}
