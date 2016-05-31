using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	void Awake() {
		//Create only one MusicPlayer for the game
		if (instance != null) {
			Destroy(gameObject);
		}
		else {
			instance = this;	//point the MusicPlayer class' instance to its 1st instance
			GameObject.DontDestroyOnLoad(gameObject);
		}	
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
